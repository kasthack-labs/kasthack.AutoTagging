# kasthack.AutoTagging

## What

[![Nuget](https://img.shields.io/nuget/v/kasthack.autotagging.dapperproxy.svg)](https://www.nuget.org/packages/kasthack.autotagging.dapperproxy/)
[![NuGet](https://img.shields.io/nuget/dt/kasthack.autotagging.dapperproxy.svg)](https://www.nuget.org/packages/kasthack.autotagging.dapperproxy/)
[![GitHub release](https://img.shields.io/github/release/kasthack-labs/kasthack.AutoTagging.svg)](https://github.com/kasthack-labs/kasthack.AutoTagging/releases/latest)
[![license](https://img.shields.io/github/license/kasthack-labs/kasthack.AutoTagging.svg)](LICENSE)
[![.NET Status](https://github.com/kasthack-labs/kasthack.AutoTagging/workflows/.NET/badge.svg)](https://github.com/kasthack-labs/kasthack.AutoTagging/actions?query=workflow%3A.NET)
[![Patreon pledges](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Dkasthack%26type%3Dpledges&style=flat)](https://patreon.com/kasthack)
[![Patreon patrons](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Dkasthack%26type%3Dpatrons&style=flat)](https://patreon.com/kasthack)

Automatic SQL tagging proxies for .NET:

* `Dapper` is currently supported.
* A custom `DbConnection` proxy that would be able to capture proper tags without recompilation is in development.

## Why does this exist?

I needed a way to tag database queries in an existing project without having to rewrite a large amount of code.

## Usage

* Install nuget package `kasthack.Autotagging.DapperProxy`
* Remove `using Dapper` from your source files.
* Add `using kasthack.Autotagging.DapperProxy` to your source files or as a global using.
* (Optional) Set `TaggingSqlMapper.AppName`
* That's it! All database queries sent through Dapper will be prefixed with the following comment:

```sql
-- App: {app_name}
-- File: {callerFile}:{callerLine}
-- Method: {callerMethod}

<your query>
```

* This allows your DBAs and DevOps teams to easily identify the sources of problematic queries and address them.

## How does it work?

* [Source generator](src/dapper/kasthack.Autotagging.DapperProxySourceGenerator/DapperSourceGenerator.cs) mirrors all Dapper methods, adds optional `[Caller(MemberName|FilePath|LineNumber)]` parameters to these methods, and generates a [nuget-package](https://nuget.org/packages/kasthack.Autotagging.DapperProxy) with proxying extension methods.
* Your code automatically picks up matching overloads, while the compiler fills in caller information during the build.
