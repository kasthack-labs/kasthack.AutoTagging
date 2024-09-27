namespace kasthack.Autotagging.DapperProxy;

internal static class QueryTagger
{
    private const string appTagPrefix = "-- App:";
    public static string? ApplyTag(string query, string appName, string callerMethod, string callerFile, int callerLine)
    {
        if (query == null || query.StartsWith(appTagPrefix, StringComparison.OrdinalIgnoreCase))
        {
            return query;
        }

        return $"""
        {appTagPrefix} {appName}
        -- File: {callerFile}:{callerLine}
        -- Method: {callerMethod}
        {query}
        """;
    }
}
