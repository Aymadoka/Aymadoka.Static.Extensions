using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的 SQL 命令，并将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">SQL 事务对象。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction) where T : new()
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
                    reader.Read();
                    return reader.ToEntity<T>();
                }
            }
        }

        /// <summary>
        /// 通过自定义命令工厂配置并执行 SQL 命令，将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="commandFactory">命令工厂委托，用于配置 <see cref="SqlCommand"/>。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, Action<SqlCommand> commandFactory) where T : new()
        {
            using (SqlCommand command = @this.CreateCommand())
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
        /// 执行指定的 SQL 命令文本（类型为 Text），并将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（类型为 Text），并在指定事务下将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">SQL 事务对象。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText, SqlTransaction transaction) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和命令类型，并将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、命令类型和事务，并将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">SQL 事务对象。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数（类型为 Text），并将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、参数和事务（类型为 Text），并将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="transaction">SQL 事务对象。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本、参数和命令类型，并将首行数据映射为实体对象。
        /// </summary>
        /// <typeparam name="T">实体类型，需有无参构造函数。</typeparam>
        /// <param name="this">SQL 连接对象。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType) where T : new()
        {
            return @this.ExecuteEntity<T>(cmdText, parameters, commandType, null);
        }
    }
}