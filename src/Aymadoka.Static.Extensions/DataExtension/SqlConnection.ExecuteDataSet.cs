using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
        public static partial class DataExtensions
        {
            /// <summary>
            /// 执行指定的 SQL 命令并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <param name="parameters">SQL 参数数组。</param>
            /// <param name="commandType">命令类型（如 Text 或 StoredProcedure）。</param>
            /// <param name="transaction">可选的事务对象。</param>
            /// <returns>查询结果的 DataSet。</returns>
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

            /// <summary>
            /// 通过自定义命令工厂配置 SqlCommand，并执行查询返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="commandFactory">用于配置 SqlCommand 的委托。</param>
            /// <returns>查询结果的 DataSet。</returns>
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

            /// <summary>
            /// 执行指定的 SQL 命令文本并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <returns>查询结果的 DataSet。</returns>
            public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText)
            {
                return @this.ExecuteDataSet(cmdText, null, CommandType.Text, null);
            }

            /// <summary>
            /// 执行指定的 SQL 命令文本（带事务）并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <param name="transaction">事务对象。</param>
            /// <returns>查询结果的 DataSet。</returns>
            public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlTransaction transaction)
            {
                return @this.ExecuteDataSet(cmdText, null, CommandType.Text, transaction);
            }

            /// <summary>
            /// 执行指定的 SQL 命令文本（指定命令类型）并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <param name="commandType">命令类型。</param>
            /// <returns>查询结果的 DataSet。</returns>
            public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, CommandType commandType)
            {
                return @this.ExecuteDataSet(cmdText, null, commandType, null);
            }

            /// <summary>
            /// 执行指定的 SQL 命令文本（指定命令类型和事务）并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <param name="commandType">命令类型。</param>
            /// <param name="transaction">事务对象。</param>
            /// <returns>查询结果的 DataSet。</returns>
            public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction)
            {
                return @this.ExecuteDataSet(cmdText, null, commandType, transaction);
            }

            /// <summary>
            /// 执行指定的 SQL 命令文本（带参数）并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <param name="parameters">SQL 参数数组。</param>
            /// <returns>查询结果的 DataSet。</returns>
            public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
            {
                return @this.ExecuteDataSet(cmdText, parameters, CommandType.Text, null);
            }

            /// <summary>
            /// 执行指定的 SQL 命令文本（带参数和事务）并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <param name="parameters">SQL 参数数组。</param>
            /// <param name="transaction">事务对象。</param>
            /// <returns>查询结果的 DataSet。</returns>
            public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction)
            {
                return @this.ExecuteDataSet(cmdText, parameters, CommandType.Text, transaction);
            }

            /// <summary>
            /// 执行指定的 SQL 命令文本（带参数和命令类型）并返回 DataSet。
            /// </summary>
            /// <param name="this">SqlConnection 实例。</param>
            /// <param name="cmdText">SQL 命令文本。</param>
            /// <param name="parameters">SQL 参数数组。</param>
            /// <param name="commandType">命令类型。</param>
            /// <returns>查询结果的 DataSet。</returns>
            public static DataSet ExecuteDataSet(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType)
            {
                return @this.ExecuteDataSet(cmdText, parameters, commandType, null);
            }
        }
}