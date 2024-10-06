namespace kasthack.Autotagging.DapperProxySourceGenerator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Dapper;

using Microsoft.CodeAnalysis;

using Namotion.Reflection;

[Generator(LanguageNames.CSharp)]
public class DapperSourceGenerator : IIncrementalGenerator
{
    /*
     * There's a bug in visual studio: it doesn't reload source generator assemblies after loading them.
     * Use console builds for testing.
     * see: https://github.com/dotnet/roslyn/issues/48083
     */
    public void Initialize(IncrementalGeneratorInitializationContext context)
        => context.RegisterPostInitializationOutput(ctx => ctx.AddSource("dapper-proxy.g.cs", this.BuildSource()));

    private string BuildSource()
    {
        Type mapper = typeof(SqlMapper);
        List<MethodInfo> extensionMethods = mapper.GetMethods(BindingFlags.Static | BindingFlags.Public)
            .Where(m => m.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false))
            .ToList();

        var docs = new Dictionary<string, string>();
        List<string> methods = extensionMethods
            .Select(m =>
            {
                string extraArgs = @", [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1";

                ParameterInfo[] targetMethodParameters = m.GetParameters();

                if (!targetMethodParameters.Any(a => a.Name == "cnn"))
                {
                    return null;
                }

                ParameterInfo taggedParameter = targetMethodParameters
                    .SingleOrDefault(a => a.Name is "sql" or "command");

                if (taggedParameter == null)
                {
                    return null;
                }

                IEnumerable<string> signatureParameters = targetMethodParameters
                    .Select((p, idx) => $"{(idx == 0 ? "this " : string.Empty)}{this.GetCSharpGenericTypeName(p.ParameterType)} {p.Name}{(!p.HasDefaultValue ? string.Empty : $" = {this.GetCSharpDefaultParameter(p)}")}");

                string returnTypeName = this.GetCSharpGenericTypeName(m.ReturnType);
                IEnumerable<string> signatureGenericArguments = m.GetGenericArguments().Select(a => this.GetCSharpTypeName(a));
                string genericArgString = signatureGenericArguments.Any() ? $"<{string.Join(", ", signatureGenericArguments)}>" : string.Empty;
                string signature = $"public static {returnTypeName} {m.Name}{genericArgString}({string.Join(", ", signatureParameters)}{extraArgs})";

                // Some dapper methods are missing docs, so I reuse docs from the methods with matching names.
                // There're warnings about parameter mismatch but that's better than nothing.
                // If you actually care, you can implement a parameter matching scheme.
                var docTag = m.GetXmlDocsElement()?.ToString();
                if (docTag == null)
                {
                    docs.TryGetValue(m.Name, out docTag);
                }
                else
                {
                    docs[m.Name] = docTag;
                }

                var docresult = string.Join(
                    "\n",
                    (
                       docTag
                            ?.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries) ?? ["//no doc"])
                    .Concat([
                        @"<param name=""callerMethod"">Auto-captured method for tagging</param>",
                        @"<param name=""callerFile"">Auto-captured file for tagging</param>",
                        @"<param name=""callerLine"">Auto-captured line for tagging</param>",
                    ])
                    .Select(a => $"    ///{a.Trim()}"));

                string methodBody = $$"""
                    {{docresult}}
                    {{signature}}
                    {
                        {{taggedParameter.Name}} = ApplyTag({{taggedParameter.Name}}, callerMethod, callerFile, callerLine);
                        {{(m.ReturnType != typeof(void) ? "return " : string.Empty)}}Dapper.SqlMapper.{{m.Name}}{{genericArgString}}({{string.Join(", ", m.GetParameters().Select(p => p.Name))}});
                    }
                """;
                return methodBody;
            })
            .Where(a => a is not null)
            .Select(a => a!)
            .ToList();

        string source = $$"""
        #nullable disable
        using System;
        using System.Runtime.CompilerServices;

        namespace kasthack.Autotagging.DapperProxy;

        public static partial class TaggingSqlMapper
        {
            private static string Dummy => @"";
        {{string.Join($"\n", methods)}}
        }
        """;

        // Add the source code to the compilation
        return source;
    }

    private string GetCSharpDefaultParameter(ParameterInfo p)
    {
        if (p.DefaultValue == null)
        {
            return "null";
        }

        if (p.ParameterType.IsEnum)
        {
            return p.ParameterType.FullName + "." + p.DefaultValue.ToString();
        }

        if (p.ParameterType == typeof(string))
        {
            return $"\"{p.DefaultValue}\""; // unsafe but whatever
        }

        return p.DefaultValue.ToString().ToLowerInvariant();
    }

    private string GetCSharpGenericTypeName(Type type)
    {
        return type.IsGenericType
            ? $"{this.GetCSharpTypeName(type.GetGenericTypeDefinition()).Split('`').First()}<{string.Join(", ", type.GetGenericArguments().Select(a => this.GetCSharpGenericTypeName(a)))}>"
            : this.GetCSharpTypeName(type);
    }

    private string GetCSharpTypeName(Type type) => (type.FullName ?? type.Name).Replace("+", ".") switch
    {
        "System.Void" => "void",
        string s => s,
    };
}
