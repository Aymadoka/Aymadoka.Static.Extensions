using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的 SQL 命令，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型（如 Text、StoredProcedure）。</param>
        /// <param name="transaction">可选的数据库事务。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction)
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
                    return reader.ToExpandoObjects();
                }
            }
        }

        /// <summary>
        /// 通过自定义命令工厂配置 DbCommand，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="commandFactory">用于配置 DbCommand 的委托。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, Action<DbCommand> commandFactory)
        {
            using (DbCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                using (IDataReader reader = command.ExecuteReader())
                {
                    return reader.ToExpandoObjects();
                }
            }
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带事务），并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText, DbTransaction transaction)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（指定命令类型），并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText, CommandType commandType)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（指定命令类型和事务），并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数），并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText, DbParameter[] parameters)
        {
            return @this.ExecuteExpandoObjects(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数和事务），并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction)
        {
            return @this.ExecuteExpandoObjects(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数和命令类型），并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType)
        {
            return @this.ExecuteExpandoObjects(cmdText, parameters, commandType, null);
        }
    }
}