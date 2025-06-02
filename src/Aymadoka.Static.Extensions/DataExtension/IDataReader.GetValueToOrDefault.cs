using Aymadoka.Static.ObjectExtension;
using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 获取指定索引的值并转换为类型 T，若失败则返回类型 T 的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="index">列索引</param>
        /// <returns>转换后的值或类型 T 的默认值</returns>
        public static T GetValueToOrDefault<T>(this IDataReader @this, int index)
        {
            try
            {
                return @this.GetValue(index).To<T>();
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 获取指定索引的值并转换为类型 T，若失败则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="index">列索引</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>转换后的值或指定的默认值</returns>
        public static T GetValueToOrDefault<T>(this IDataReader @this, int index, T defaultValue)
        {
            try
            {
                return @this.GetValue(index).To<T>();
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 获取指定索引的值并转换为类型 T，若失败则通过工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="index">列索引</param>
        /// <param name="defaultValueFactory">转换失败时用于生成默认值的工厂方法</param>
        /// <returns>转换后的值或工厂方法生成的默认值</returns>
        public static T GetValueToOrDefault<T>(this IDataReader @this, int index, Func<IDataReader, int, T> defaultValueFactory)
        {
            try
            {
                return @this.GetValue(index).To<T>();
            }
            catch
            {
                return defaultValueFactory(@this, index);
            }
        }

        /// <summary>
        /// 获取指定列名的值并转换为类型 T，若失败则返回类型 T 的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="columnName">列名</param>
        /// <returns>转换后的值或类型 T 的默认值</returns>
        public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName)
        {
            try
            {
                return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 获取指定列名的值并转换为类型 T，若失败则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="columnName">列名</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>转换后的值或指定的默认值</returns>
        public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName, T defaultValue)
        {
            try
            {
                return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 获取指定列名的值并转换为类型 T，若失败则通过工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">数据读取器</param>
        /// <param name="columnName">列名</param>
        /// <param name="defaultValueFactory">转换失败时用于生成默认值的工厂方法</param>
        /// <returns>转换后的值或工厂方法生成的默认值</returns>
        public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName, Func<IDataReader, string, T> defaultValueFactory)
        {
            try
            {
                return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
            }
            catch
            {
                return defaultValueFactory(@this, columnName);
            }
        }
    }
}
