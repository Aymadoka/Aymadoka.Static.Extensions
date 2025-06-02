using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行指定的 SQL 命令，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">可选的事务对象。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction)
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
                    return reader.ToExpandoObjects();
                }
            }
        }

        /// <summary>
        /// 通过自定义命令工厂配置并执行 SQL 命令，将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="commandFactory">用于配置 <see cref="SqlCommand"/> 的委托。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, Action<SqlCommand> commandFactory)
        {
            using (SqlCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                using (IDataReader reader = command.ExecuteReader())
                {
                    return reader.ToExpandoObjects();
                }
            }
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），在指定事务中，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="transaction">可选的事务对象。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText, SqlTransaction transaction)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），指定命令类型，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText, CommandType commandType)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, commandType, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本（无参数），指定命令类型和事务，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="commandType">命令类型。</param>
        /// <param name="transaction">可选的事务对象。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction)
        {
            return @this.ExecuteExpandoObjects(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
        {
            return @this.ExecuteExpandoObjects(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数，在指定事务中，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="transaction">可选的事务对象。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction)
        {
            return @this.ExecuteExpandoObjects(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// 执行指定的 SQL 命令文本和参数，指定命令类型，并将结果集转换为动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="SqlConnection"/> 实例。</param>
        /// <param name="cmdText">SQL 命令文本。</param>
        /// <param name="parameters">SQL 参数数组。</param>
        /// <param name="commandType">命令类型。</param>
        /// <returns>动态对象集合，表示查询结果。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType)
        {
            return @this.ExecuteExpandoObjects(cmdText, parameters, commandType, null);
        }
    }
}