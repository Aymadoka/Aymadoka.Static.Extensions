using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 获取指定索引的值，若获取失败则返回类型的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="index">列索引</param>
        /// <returns>指定类型的值或默认值</returns>
        public static T GetValueAsOrDefault<T>(this IDataReader @this, int index)
        {
            try
            {
                return (T)@this.GetValue(index);
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 获取指定索引的值，若获取失败则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="index">列索引</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>指定类型的值或默认值</returns>
        public static T GetValueAsOrDefault<T>(this IDataReader @this, int index, T defaultValue)
        {
            try
            {
                return (T)@this.GetValue(index);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 获取指定索引的值，若获取失败则通过工厂方法生成默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="index">列索引</param>
        /// <param name="defaultValueFactory">默认值工厂方法</param>
        /// <returns>指定类型的值或工厂方法生成的默认值</returns>
        public static T GetValueAsOrDefault<T>(this IDataReader @this, int index, Func<IDataReader, int, T> defaultValueFactory)
        {
            try
            {
                return (T)@this.GetValue(index);
            }
            catch
            {
                return defaultValueFactory(@this, index);
            }
        }

        /// <summary>
        /// 获取指定列名的值，若获取失败则返回类型的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="columnName">列名</param>
        /// <returns>指定类型的值或默认值</returns>
        public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName)
        {
            try
            {
                return (T)@this.GetValue(@this.GetOrdinal(columnName));
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 获取指定列名的值，若获取失败则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="columnName">列名</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>指定类型的值或默认值</returns>
        public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName, T defaultValue)
        {
            try
            {
                return (T)@this.GetValue(@this.GetOrdinal(columnName));
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 获取指定列名的值，若获取失败则通过工厂方法生成默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="columnName">列名</param>
        /// <param name="defaultValueFactory">默认值工厂方法</param>
        /// <returns>指定类型的值或工厂方法生成的默认值</returns>
        public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName, Func<IDataReader, string, T> defaultValueFactory)
        {
            try
            {
                return (T)@this.GetValue(@this.GetOrdinal(columnName));
            }
            catch
            {
                return defaultValueFactory(@this, columnName);
            }
        }
    }
}