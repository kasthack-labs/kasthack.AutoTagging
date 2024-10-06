namespace kasthack.Autotagging.DapperProxy;

internal static class QueryTagger
{
    private const string AppTagPrefix = "-- App:";

    public static string? ApplyTag(string query, string appName, string callerMethod, string callerFile, int callerLine)
    {
        if (query?.StartsWith(AppTagPrefix, StringComparison.OrdinalIgnoreCase) ?? true)
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
