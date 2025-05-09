using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Reflection;

namespace Aymadoka.Static.DataExtension;

public static partial class DataExtensions
{
    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction)
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

            var ds = new DataSet();
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                dataAdapter.Fill(ds);
            }

            return ds;
        }
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, Action<SqlCommand> commandFactory)
    {
        using (SqlCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            var ds = new DataSet();
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                dataAdapter.Fill(ds);
            }

            return ds;
        }
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText)
    {
        return @this.ExecuteDataSet(cmdText, null, CommandType.Text, null);
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlTransaction transaction)
    {
        return @this.ExecuteDataSet(cmdText, null, CommandType.Text, transaction);
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteDataSet(cmdText, null, commandType, null);
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction)
    {
        return @this.ExecuteDataSet(cmdText, null, commandType, transaction);
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
    {
        return @this.ExecuteDataSet(cmdText, parameters, CommandType.Text, null);
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction)
    {
        return @this.ExecuteDataSet(cmdText, parameters, CommandType.Text, transaction);
    }

    public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType)
    {
        return @this.ExecuteDataSet(cmdText, parameters, commandType, null);
    }
}
