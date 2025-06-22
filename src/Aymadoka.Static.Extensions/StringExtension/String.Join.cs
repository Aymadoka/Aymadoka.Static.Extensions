using System.Collections.Generic;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 使用指定的分隔符连接字符串数组的所有元素。
        /// </summary>
        /// <param name="separator">分隔符。</param>
        /// <param name="value">要连接的字符串数组。</param>
        /// <returns>连接后的字符串。</returns>
        public static string Join(this string separator, string[] value)
        {
            return string.Join(separator, value);
        }

        /// <summary>
        /// 使用指定的分隔符连接对象数组的所有元素。
        /// </summary>
        /// <param name="separator">分隔符。</param>
        /// <param name="values">要连接的对象数组。</param>
        /// <returns>连接后的字符串。</returns>
        public static string Join(this string separator, object[] values)
        {
            return string.Join(separator, values);
        }

        /// <summary>
        /// 使用指定的分隔符连接泛型集合的所有元素。
        /// </summary>
        /// <typeparam name="T">集合元素类型。</typeparam>
        /// <param name="separator">分隔符。</param>
        /// <param name="values">要连接的集合。</param>
        /// <returns>连接后的字符串。</returns>
        public static string Join<T>(this string separator, IEnumerable<T> values)
        {
            return string.Join(separator, values);
        }

        /// <summary>
        /// 使用指定的分隔符连接字符串集合的所有元素。
        /// </summary>
        /// <param name="separator">分隔符。</param>
        /// <param name="values">要连接的字符串集合。</param>
        /// <returns>连接后的字符串。</returns>
        public static string Join(this string separator, IEnumerable<string> values)
        {
            return string.Join(separator, values);
        }

        /// <summary>
        /// 使用指定的分隔符连接字符串数组中指定范围的元素。
        /// </summary>
        /// <param name="separator">分隔符。</param>
        /// <param name="value">要连接的字符串数组。</param>
        /// <param name="startIndex">起始索引。</param>
        /// <param name="count">要连接的元素数量。</param>
        /// <returns>连接后的字符串。</returns>
        public static string Join(this string separator, string[] value, int startIndex, int count)
        {
            return string.Join(separator, value, startIndex, count);
        }
    }
}
