using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的命令并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型（如 Text、StoredProcedure）。</param>
        /// <param name="transaction">可选的数据库事务。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction) where T : new()
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
                    return reader.ToEntities<T>();
                }
            }
        }

        /// <summary>
        /// 通过命令工厂自定义 DbCommand 并执行，将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="commandFactory">用于配置 DbCommand 的委托。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, Action<DbCommand> commandFactory) where T : new()
        {
            using (DbCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                using (IDataReader reader = command.ExecuteReader())
                {
                    return reader.ToEntities<T>();
                }
            }
        }

        /// <summary>
        /// 执行指定的 SQL 文本命令并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 文本命令（带事务）并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText, DbTransaction transaction) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的命令（指定命令类型）并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的命令（指定命令类型和事务）并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 文本命令（带参数）并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText, DbParameter[] parameters) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 文本命令（带参数和事务）并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的命令（带参数和命令类型）并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">命令参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, parameters, commandType, null);
        }
    }
}