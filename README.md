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

* Dapper is currently supported
* I'm working on custom DbConnection proxy.

## Why does this exist

I needed to tag database queries in an existing project without rewriting tons of code.

## Usage

* Install nuget package `kasthack.Autotagging.DapperProxy`
* Remove `using Dapper` from your source.
* Add `using kasthack.Autotagging.DapperProxy` to source files / global using.
* (optionally) Set `TaggingSqlMapper.AppName`
* Boom! All database queries sent through dapper start with the comment:

```sql
-- App: {app_name}
-- File: {callerFile}:{callerLine}
-- Method: {callerMethod}

<your query>
```

* Now your DBAs and devops can easily detect sources of problematic queries and deal with them.

## How does it work

* Source generator that mirrors all dapper methods, adds `[Callel(MemberName|FilePath|LineNumber)]` parameters to these methods, and prepends them to queries.
