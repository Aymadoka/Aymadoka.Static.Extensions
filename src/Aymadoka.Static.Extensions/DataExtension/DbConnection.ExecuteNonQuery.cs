using System;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行非查询 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction)
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

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 通过自定义命令工厂执行非查询 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="commandFactory">命令工厂委托。</param>
        public static void ExecuteNonQuery(this DbConnection @this, Action<DbCommand> commandFactory)
        {
            using (DbCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 执行无参数的文本 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText)
        {
            @this.ExecuteNonQuery(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行带事务的无参数文本 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">数据库事务。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbTransaction transaction)
        {
            @this.ExecuteNonQuery(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定命令类型的无参数 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText, CommandType commandType)
        {
            @this.ExecuteNonQuery(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定命令类型和事务的无参数 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction)
        {
            @this.ExecuteNonQuery(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行带参数的文本 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters)
        {
            @this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行带参数和事务的文本 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="transaction">数据库事务。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction)
        {
            @this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行带参数和指定命令类型的 SQL 命令。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType)
        {
            @this.ExecuteNonQuery(cmdText, parameters, commandType, null);
        }
    }
}