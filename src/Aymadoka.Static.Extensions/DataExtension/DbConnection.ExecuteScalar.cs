using System;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 SQL 命令并返回结果集的第一行第一列，忽略其他行和列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型（如 Text 或 StoredProcedure）。</param>
        /// <param name="transaction">可选的数据库事务。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction)
        {
            using (DbCommand command = @this.CreateCommand())
            {
                command.CommandText = cmdText;
                command.CommandType = commandType;
                command.Transaction = transaction;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteScalar();
            }
        }

        /// <summary>
        /// 通过自定义命令工厂配置 DbCommand 并执行 ExecuteScalar。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="commandFactory">用于配置 DbCommand 的委托。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, Action<DbCommand> commandFactory)
        {
            using (DbCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                return command.ExecuteScalar();
            }
        }

        /// <summary>
        /// 执行 SQL 命令文本并返回结果集的第一行第一列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText)
        {
            return @this.ExecuteScalar(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行 SQL 命令文本（带事务）并返回结果集的第一行第一列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText, DbTransaction transaction)
        {
            return @this.ExecuteScalar(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定类型的 SQL 命令并返回结果集的第一行第一列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText, CommandType commandType)
        {
            return @this.ExecuteScalar(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定类型的 SQL 命令（带事务）并返回结果集的第一行第一列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction)
        {
            return @this.ExecuteScalar(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行带参数的 SQL 命令文本并返回结果集的第一行第一列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText, DbParameter[] parameters)
        {
            return @this.ExecuteScalar(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行带参数和事务的 SQL 命令文本并返回结果集的第一行第一列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction)
        {
            return @this.ExecuteScalar(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行带参数和指定类型的 SQL 命令并返回结果集的第一行第一列。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">要执行的 SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>结果集的第一行第一列的值。</returns>
        public static object ExecuteScalar(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType)
        {
            return @this.ExecuteScalar(cmdText, parameters, commandType, null);
        }
    }
}