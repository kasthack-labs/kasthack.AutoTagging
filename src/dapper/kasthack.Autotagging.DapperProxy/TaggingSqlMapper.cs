namespace kasthack.Autotagging.DapperProxy;
using System.Data;
using System.Reflection;

/// <summary>
/// Proxy to Dapper.SqlMapper that adds query tags to every request.
/// </summary>
public static partial class TaggingSqlMapper
{
    private static void DummyCheck()
    {
        // checks if generator worked
        _ = TaggingSqlMapper.Dummy;
    }

    /// <summary>
    /// Application name for tagging. Defaults to entry assembly name.
    /// </summary>
    public static string AppName { get; set; } = Assembly.GetEntryAssembly().GetName().Name;

    private static string? ApplyTag(string sql, string callerMethod, string callerFile, int callerLine)
    {
        return QueryTagger.ApplyTag(sql, AppName, callerMethod, callerFile, callerLine);
    }

    private static Dapper.CommandDefinition ApplyTag(Dapper.CommandDefinition command, string callerMethod, string callerFile, int callerLine)
    {
        var sql = ApplyTag(command.CommandText, callerMethod, callerFile, callerLine)!;
        return new Dapper.CommandDefinition(sql, command.Parameters, command.Transaction, command.CommandTimeout, command.CommandType, command.Flags, command.CancellationToken);
    }
}
