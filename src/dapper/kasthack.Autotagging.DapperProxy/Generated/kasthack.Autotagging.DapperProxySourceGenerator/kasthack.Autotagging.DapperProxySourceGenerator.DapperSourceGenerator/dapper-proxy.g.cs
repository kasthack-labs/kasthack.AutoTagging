#nullable disable
using System;
using System.Runtime.CompilerServices;

namespace kasthack.Autotagging.DapperProxy;

public static partial class TaggingSqlMapper
{
    private static string Dummy => @"";
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>> QueryAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>> QueryAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefaultAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstOrDefaultAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefaultAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleOrDefaultAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>> QueryAsync<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QueryFirstAsync<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefaultAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QueryFirstOrDefaultAsync<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefaultAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QuerySingleAsync<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefaultAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QuerySingleOrDefaultAsync<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefaultAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefaultAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstOrDefaultAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefaultAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleOrDefaultAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>> QueryAsync(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstAsync(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstAsync(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefaultAsync(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstOrDefaultAsync(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleAsync(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleAsync(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefaultAsync(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleOrDefaultAsync(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>> QueryAsync<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>> QueryAsync(this System.Data.IDbConnection cnn, System.Type type, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync(cnn, type, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstAsync(this System.Data.IDbConnection cnn, System.Type type, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstAsync(cnn, type, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QueryFirstAsync<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstAsync<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefaultAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QueryFirstOrDefaultAsync(this System.Data.IDbConnection cnn, System.Type type, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, type, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefaultAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QueryFirstOrDefaultAsync<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefaultAsync<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleAsync(this System.Data.IDbConnection cnn, System.Type type, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleAsync(cnn, type, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QuerySingleAsync<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleAsync<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefaultAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> QuerySingleOrDefaultAsync(this System.Data.IDbConnection cnn, System.Type type, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, type, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefaultAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a single-row query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> QuerySingleOrDefaultAsync<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefaultAsync<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a command asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for this query.</param>
    ///<param name="param">The parameters to use for this query.</param>
    ///<param name="transaction">The transaction to use for this query.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>The number of rows affected.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Int32> ExecuteAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a command asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute on this connection.</param>
    ///<returns>The number of rows affected.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Int32> ExecuteAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Func<TFirst, TSecond, TReturn> map, System.String splitOn = "Id", [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TReturn>(cnn, command, map, splitOn);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Func<TFirst, TSecond, TThird, TReturn> map, System.String splitOn = "Id", [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TReturn>(cnn, command, map, splitOn);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Func<TFirst, TSecond, TThird, TFourth, TReturn> map, System.String splitOn = "Id", [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(cnn, command, map, splitOn);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, System.String splitOn = "Id", [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(cnn, command, map, splitOn);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, System.String splitOn = "Id", [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(cnn, command, map, splitOn);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, System.String splitOn = "Id", [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(cnn, command, map, splitOn);
    }
        ///<member name="M:Dapper.SqlMapper.QueryAsync(System.Data.IDbConnection,System.Type,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a query asynchronously using Task.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="command">The command used to query on this connection.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TReturn>> QueryAsync<TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Type[] types, System.Func<System.Object[], TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryAsync<TReturn>(cnn, sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryMultipleAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a command that returns multiple result sets, and access each in turn.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for this query.</param>
    ///<param name="param">The parameters to use for this query.</param>
    ///<param name="transaction">The transaction to use for this query.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<Dapper.SqlMapper.GridReader> QueryMultipleAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryMultipleAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryMultipleAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a command that returns multiple result sets, and access each in turn.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command to execute for this query.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<Dapper.SqlMapper.GridReader> QueryMultipleAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryMultipleAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReaderAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL and return an <see cref="T:System.Data.IDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="sql">The SQL to execute.</param>
    ///<param name="param">The parameters to use for this command.</param>
    ///<param name="transaction">The transaction to use for this command.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>An <see cref="T:System.Data.IDataReader" /> that can be used to iterate over the results of the SQL query.</returns>
    ///<remarks>
    ///This is typically used when the results of a query are not processed by Dapper, for example, used to fill a <see cref="T:System.Data.DataTable" />
    ///or <see cref="T:DataSet" />.
    ///</remarks>
    ///<example>
    ///<code>
    ///<![CDATA[
    ///DataTable table = new DataTable("MyTable");
    ///using (var reader = ExecuteReader(cnn, sql, param))
    ///{
    ///table.Load(reader);
    ///}
    ///]]>
    ///</code>
    ///</example>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Data.IDataReader> ExecuteReaderAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReaderAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReaderAsync(System.Data.Common.DbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL and return a <see cref="T:System.Data.Common.DbDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="sql">The SQL to execute.</param>
    ///<param name="param">The parameters to use for this command.</param>
    ///<param name="transaction">The transaction to use for this command.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(this System.Data.Common.DbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReaderAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReaderAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL and return an <see cref="T:System.Data.IDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<returns>An <see cref="T:System.Data.IDataReader" /> that can be used to iterate over the results of the SQL query.</returns>
    ///<remarks>
    ///This is typically used when the results of a query are not processed by Dapper, for example, used to fill a <see cref="T:System.Data.DataTable" />
    ///or <see cref="T:DataSet" />.
    ///</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Data.IDataReader> ExecuteReaderAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReaderAsync(System.Data.Common.DbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL and return a <see cref="T:System.Data.Common.DbDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(this System.Data.Common.DbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReaderAsync(System.Data.IDbConnection,Dapper.CommandDefinition,System.Data.CommandBehavior)">
    ///<summary>
    ///Execute parameterized SQL and return an <see cref="T:System.Data.IDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<param name="commandBehavior">The <see cref="T:System.Data.CommandBehavior" /> flags for this reader.</param>
    ///<returns>An <see cref="T:System.Data.IDataReader" /> that can be used to iterate over the results of the SQL query.</returns>
    ///<remarks>
    ///This is typically used when the results of a query are not processed by Dapper, for example, used to fill a <see cref="T:System.Data.DataTable" />
    ///or <see cref="T:DataSet" />.
    ///</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Data.IDataReader> ExecuteReaderAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Data.CommandBehavior commandBehavior, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command, commandBehavior);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReaderAsync(System.Data.Common.DbConnection,Dapper.CommandDefinition,System.Data.CommandBehavior)">
    ///<summary>
    ///Execute parameterized SQL and return a <see cref="T:System.Data.Common.DbDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<param name="commandBehavior">The <see cref="T:System.Data.CommandBehavior" /> flags for this reader.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(this System.Data.Common.DbConnection cnn, Dapper.CommandDefinition command, System.Data.CommandBehavior commandBehavior, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command, commandBehavior);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalarAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="sql">The SQL to execute.</param>
    ///<param name="param">The parameters to use for this command.</param>
    ///<param name="transaction">The transaction to use for this command.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>The first cell returned, as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> ExecuteScalarAsync(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalarAsync(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalarAsync(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="sql">The SQL to execute.</param>
    ///<param name="param">The parameters to use for this command.</param>
    ///<param name="transaction">The transaction to use for this command.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>The first cell returned, as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> ExecuteScalarAsync<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalarAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalarAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<returns>The first cell selected as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<System.Object> ExecuteScalarAsync(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalarAsync(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalarAsync(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<returns>The first cell selected as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Threading.Tasks.Task<T> ExecuteScalarAsync<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalarAsync<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.Execute(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for this query.</param>
    ///<param name="param">The parameters to use for this query.</param>
    ///<param name="transaction">The transaction to use for this query.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>The number of rows affected.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Int32 Execute(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Execute(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Execute(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute on this connection.</param>
    ///<returns>The number of rows affected.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Int32 Execute(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Execute(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalar(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="sql">The SQL to execute.</param>
    ///<param name="param">The parameters to use for this command.</param>
    ///<param name="transaction">The transaction to use for this command.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>The first cell selected as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object ExecuteScalar(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalar(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalar(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="sql">The SQL to execute.</param>
    ///<param name="param">The parameters to use for this command.</param>
    ///<param name="transaction">The transaction to use for this command.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>The first cell selected as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T ExecuteScalar<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalar<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalar(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<returns>The first cell selected as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object ExecuteScalar(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalar(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteScalar(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL that selects a single value.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<returns>The first cell selected as <see cref="T:System.Object" />.</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T ExecuteScalar<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteScalar<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReader(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute parameterized SQL and return an <see cref="T:System.Data.IDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="sql">The SQL to execute.</param>
    ///<param name="param">The parameters to use for this command.</param>
    ///<param name="transaction">The transaction to use for this command.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///<returns>An <see cref="T:System.Data.IDataReader" /> that can be used to iterate over the results of the SQL query.</returns>
    ///<remarks>
    ///This is typically used when the results of a query are not processed by Dapper, for example, used to fill a <see cref="T:System.Data.DataTable" />
    ///or <see cref="T:DataSet" />.
    ///</remarks>
    ///<example>
    ///<code>
    ///<![CDATA[
    ///DataTable table = new DataTable("MyTable");
    ///using (var reader = ExecuteReader(cnn, sql, param))
    ///{
    ///table.Load(reader);
    ///}
    ///]]>
    ///</code>
    ///</example>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Data.IDataReader ExecuteReader(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReader(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReader(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute parameterized SQL and return an <see cref="T:System.Data.IDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<returns>An <see cref="T:System.Data.IDataReader" /> that can be used to iterate over the results of the SQL query.</returns>
    ///<remarks>
    ///This is typically used when the results of a query are not processed by Dapper, for example, used to fill a <see cref="T:System.Data.DataTable" />
    ///or <see cref="T:DataSet" />.
    ///</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Data.IDataReader ExecuteReader(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReader(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.ExecuteReader(System.Data.IDbConnection,Dapper.CommandDefinition,System.Data.CommandBehavior)">
    ///<summary>
    ///Execute parameterized SQL and return an <see cref="T:System.Data.IDataReader" />.
    ///</summary>
    ///<param name="cnn">The connection to execute on.</param>
    ///<param name="command">The command to execute.</param>
    ///<param name="commandBehavior">The <see cref="T:System.Data.CommandBehavior" /> flags for this reader.</param>
    ///<returns>An <see cref="T:System.Data.IDataReader" /> that can be used to iterate over the results of the SQL query.</returns>
    ///<remarks>
    ///This is typically used when the results of a query are not processed by Dapper, for example, used to fill a <see cref="T:System.Data.DataTable" />
    ///or <see cref="T:DataSet" />.
    ///</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Data.IDataReader ExecuteReader(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, System.Data.CommandBehavior commandBehavior, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.ExecuteReader(cnn, command, commandBehavior);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a sequence of dynamic objects with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer the results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<System.Object> Query(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query(cnn, sql, param, transaction, buffered, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirst(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QueryFirst(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirst(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefault(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QueryFirstOrDefault(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefault(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingle(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QuerySingle(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingle(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefault(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QuerySingleOrDefault(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefault(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a sequence of dynamic objects with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer the results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: each row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<T> Query<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<T>(cnn, sql, param, transaction, buffered, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirst(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QueryFirst<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirst<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefault(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QueryFirstOrDefault<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefault<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingle(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QuerySingle<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingle<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefault(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Return a dynamic object with properties matching the columns.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<remarks>Note: the row can be accessed via "dynamic", or by casting to an IDictionary&lt;string,object&gt;</remarks>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QuerySingleOrDefault<T>(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefault<T>(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<System.Object> Query(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query(cnn, type, sql, param, transaction, buffered, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirst(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QueryFirst(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirst(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefault(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QueryFirstOrDefault(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefault(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingle(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QuerySingle(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingle(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefault(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Object QuerySingleOrDefault(this System.Data.IDbConnection cnn, System.Type type, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefault(cnn, type, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<T> Query<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirst(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QueryFirst<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirst<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryFirstOrDefault(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QueryFirstOrDefault<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryFirstOrDefault<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingle(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QuerySingle<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingle<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QuerySingleOrDefault(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static T QuerySingleOrDefault<T>(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QuerySingleOrDefault<T>(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.QueryMultiple(System.Data.IDbConnection,System.String,System.Object,System.Data.IDbTransaction,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Execute a command that returns multiple result sets, and access each in turn.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="sql">The SQL to execute for this query.</param>
    ///<param name="param">The parameters to use for this query.</param>
    ///<param name="transaction">The transaction to use for this query.</param>
    ///<param name="commandTimeout">Number of seconds before command execution timeout.</param>
    ///<param name="commandType">Is it a stored proc or a batch?</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static Dapper.SqlMapper.GridReader QueryMultiple(this System.Data.IDbConnection cnn, System.String sql, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryMultiple(cnn, sql, param, transaction, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.QueryMultiple(System.Data.IDbConnection,Dapper.CommandDefinition)">
    ///<summary>
    ///Execute a command that returns multiple result sets, and access each in turn.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="command">The command to execute for this query.</param>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static Dapper.SqlMapper.GridReader QueryMultiple(this System.Data.IDbConnection cnn, Dapper.CommandDefinition command, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        command = ApplyTag(command, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.QueryMultiple(cnn, command);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<TFirst, TSecond, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
        ///<member name="M:Dapper.SqlMapper.Query(System.Data.IDbConnection,System.Type,System.String,System.Object,System.Data.IDbTransaction,System.Boolean,System.Nullable{System.Int32},System.Nullable{System.Data.CommandType})">
    ///<summary>
    ///Executes a single-row query, returning the data typed as <paramref name="type" />.
    ///</summary>
    ///<param name="cnn">The connection to query on.</param>
    ///<param name="type">The type to return.</param>
    ///<param name="sql">The SQL to execute for the query.</param>
    ///<param name="param">The parameters to pass, if any.</param>
    ///<param name="transaction">The transaction to use, if any.</param>
    ///<param name="buffered">Whether to buffer results in memory.</param>
    ///<param name="commandTimeout">The command timeout (in seconds).</param>
    ///<param name="commandType">The type of command to execute.</param>
    ///<exception cref="T:System.ArgumentNullException"><paramref name="type" /> is <c>null</c>.</exception>
    ///<returns>
    ///A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column is assumed, otherwise an instance is
    ///created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
    ///</returns>
    ///</member>
    ///<param name="callerMethod">Auto-captured method for tagging</param>
    ///<param name="callerFile">Auto-captured file for tagging</param>
    ///<param name="callerLine">Auto-captured line for tagging</param>
    public static System.Collections.Generic.IEnumerable<TReturn> Query<TReturn>(this System.Data.IDbConnection cnn, System.String sql, System.Type[] types, System.Func<System.Object[], TReturn> map, System.Object param = null, System.Data.IDbTransaction transaction = null, System.Boolean buffered = true, System.String splitOn = "Id", System.Nullable<System.Int32> commandTimeout = null, System.Nullable<System.Data.CommandType> commandType = null, [CallerMemberName] string callerMethod = null, [CallerFilePath] string callerFile = null, [CallerLineNumber] int callerLine = -1)
    {
        sql = ApplyTag(sql, callerMethod, callerFile, callerLine);
        return Dapper.SqlMapper.Query<TReturn>(cnn, sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
}