using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    /// <summary>
    /// 提供针对 <see cref="SqlConnection"/> 的扩展方法，用于执行 SQL 命令并将结果集映射为实体集合。
    /// </summary>
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的 SQL 命令，并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">可选的事务对象。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction) where T : new()
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

                using (IDataReader reader = command.ExecuteReader())
                {
                    return reader.ToEntities<T>();
                }
            }
        }

        /// <summary>
        /// 通过自定义命令工厂配置 <see cref="SqlCommand"/>，并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="commandFactory">用于配置 <see cref="SqlCommand"/> 的委托。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, Action<SqlCommand> commandFactory) where T : new()
        {
            using (SqlCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                using (IDataReader reader = command.ExecuteReader())
                {
                    return reader.ToEntities<T>();
                }
            }
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本，并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带事务），并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText, SqlTransaction transaction) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（指定命令类型），并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（指定命令类型和事务），并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数），并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数和事务），并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="transaction">事务对象。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（带参数和命令类型），并将结果集映射为实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntities<T>(cmdText, parameters, commandType, null);
        }
    }
}