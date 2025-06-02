using System;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的命令并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction)
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

                return command.ExecuteReader();
            }
        }

        /// <summary>
        /// 通过自定义命令工厂配置 DbCommand 并执行，返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="commandFactory">用于配置 DbCommand 的委托。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, Action<DbCommand> commandFactory)
        {
            using (DbCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                return command.ExecuteReader();
            }
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText)
        {
            return @this.ExecuteReader(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和事务并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText, DbTransaction transaction)
        {
            return @this.ExecuteReader(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和命令类型并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText, CommandType commandType)
        {
            return @this.ExecuteReader(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、命令类型和事务并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction)
        {
            return @this.ExecuteReader(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText, DbParameter[] parameters)
        {
            return @this.ExecuteReader(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、参数和事务并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction)
        {
            return @this.ExecuteReader(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、参数和命令类型并返回 DbDataReader。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>DbDataReader 对象。</returns>
        public static DbDataReader ExecuteReader(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType)
        {
            return @this.ExecuteReader(cmdText, parameters, commandType, null);
        }
    }
}