using System;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的 SQL 命令，并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction)
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

                using (IDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.ToExpandoObject();
                }
            }
        }

        /// <summary>
        /// 使用自定义命令工厂执行 SQL 命令，并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="commandFactory">命令工厂委托，用于配置 DbCommand。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, Action<DbCommand> commandFactory)
        {
            using (DbCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                using (IDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.ToExpandoObject();
                }
            }
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本，并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText)
        {
            return @this.ExecuteExpandoObject(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带事务），并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText, DbTransaction transaction)
        {
            return @this.ExecuteExpandoObject(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（指定命令类型），并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText, CommandType commandType)
        {
            return @this.ExecuteExpandoObject(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（指定命令类型和事务），并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction)
        {
            return @this.ExecuteExpandoObject(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数），并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText, DbParameter[] parameters)
        {
            return @this.ExecuteExpandoObject(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数和事务），并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction)
        {
            return @this.ExecuteExpandoObject(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数和命令类型），并将首行结果转换为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>首行结果的动态对象表示。</returns>
        public static dynamic ExecuteExpandoObject(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType)
        {
            return @this.ExecuteExpandoObject(cmdText, parameters, commandType, null);
        }
    }
}