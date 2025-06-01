using System;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的 SQL 命令并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型（如 Text、StoredProcedure）。</param>
        /// <param name="transaction">可选的数据库事务。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction) where T : new()
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
                    return reader.ToEntity<T>();
                }
            }
        }

        /// <summary>
        /// 通过自定义命令工厂配置 DbCommand，执行并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="commandFactory">用于配置 DbCommand 的委托。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, Action<DbCommand> commandFactory) where T : new()
        {
            using (DbCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                using (IDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.ToEntity<T>();
                }
            }
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（类型为 Text），并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, CommandType.Text, null);
        }

        /// <returns>A T.</returns>
        /// <summary>
        /// 执行指定的 SQL 命令文本（类型为 Text），在指定事务下将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText, DbTransaction transaction) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和命令类型，并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、命令类型和事务，并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数（类型为 Text），并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText, DbParameter[] parameters) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、参数和事务（类型为 Text），并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="transaction">数据库事务。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、参数和命令类型，并将结果的第一行映射为实体类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据库连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, parameters, commandType, null);
        }
    }
}