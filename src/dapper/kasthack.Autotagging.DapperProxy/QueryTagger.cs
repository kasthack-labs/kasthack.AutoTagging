namespace kasthack.Autotagging.DapperProxy;

internal static class QueryTagger
{
    private const string AppTagPrefix = "-- App:";

    public static string? ApplyTag(string query, string appName, string callerMethod, string callerFile, int callerLine)
    {
        if (query == null || query.StartsWith(AppTagPrefix, StringComparison.OrdinalIgnoreCase))
        {
            return query;
        }

        return $"""
        {AppTagPrefix} {appName}
        -- Method: {callerMethod}
        -- File: {callerFile}:{callerLine}
        {query}
        """;
    }
}
