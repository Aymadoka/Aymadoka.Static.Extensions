using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Aymadoka.Static.DataExtension;

public static partial class DataExtensions
{
    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction)
    {
        using (SqlCommand command = @this.CreateCommand())
        {
            command.CommandText = cmdText;
            command.CommandType = commandType;
            command.Transaction = transaction;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            return (T)command.ExecuteScalar();
        }
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, Action<SqlCommand> commandFactory)
    {
        using (SqlCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            return (T)command.ExecuteScalar();
        }
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText)
    {
        return @this.ExecuteScalarAs<T>(cmdText, null, CommandType.Text, null);
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText, SqlTransaction transaction)
    {
        return @this.ExecuteScalarAs<T>(cmdText, null, CommandType.Text, transaction);
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteScalarAs<T>(cmdText, null, commandType, null);
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction)
    {
        return @this.ExecuteScalarAs<T>(cmdText, null, commandType, transaction);
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
    {
        return @this.ExecuteScalarAs<T>(cmdText, parameters, CommandType.Text, null);
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction)
    {
        return @this.ExecuteScalarAs<T>(cmdText, parameters, CommandType.Text, transaction);
    }

    public static T ExecuteScalarAs<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType)
    {
        return @this.ExecuteScalarAs<T>(cmdText, parameters, commandType, null);
    }
}
