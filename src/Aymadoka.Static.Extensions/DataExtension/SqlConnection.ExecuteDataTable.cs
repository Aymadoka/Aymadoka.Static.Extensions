using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的 SQL 命令并返回结果 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型（如 Text 或 StoredProcedure）。</param>
        /// <param name="transaction">可选的事务对象。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction)
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

                return ds.Tables[0];
            }
        }

        /// <summary>
        /// 通过委托自定义 SqlCommand，执行命令并返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="commandFactory">用于配置 SqlCommand 的委托。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, Action<SqlCommand> commandFactory)
        {
            using (SqlCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                var ds = new DataSet();
                using (var dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(ds);
                }

                return ds.Tables[0];
            }
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText)
        {
            return @this.ExecuteDataTable(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），并在指定事务中返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, SqlTransaction transaction)
        {
            return @this.ExecuteDataTable(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），指定命令类型，返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, CommandType commandType)
        {
            return @this.ExecuteDataTable(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），指定命令类型和事务，返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction)
        {
            return @this.ExecuteDataTable(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数，返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
        {
            return @this.ExecuteDataTable(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数，在指定事务中返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction)
        {
            return @this.ExecuteDataTable(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数，指定命令类型，返回 DataTable。
        /// </summary>
        /// <param name="this">SqlConnection 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>查询结果的 DataTable。</returns>
        public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType)
        {
            return @this.ExecuteDataTable(cmdText, parameters, commandType, null);
        }
    }
}