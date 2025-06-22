using System.Collections.Generic;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 将集合中的元素使用指定的字符串分隔符连接为一个字符串。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要连接的集合。</param>
        /// <param name="separator">用于分隔元素的字符串。</param>
        /// <returns>连接后的字符串。</returns>
        public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
        {
            return string.Join(separator, @this);
        }

        /// <summary>
        /// 将集合中的元素使用指定的字符分隔符连接为一个字符串。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要连接的集合。</param>
        /// <param name="separator">用于分隔元素的字符。</param>
        /// <returns>连接后的字符串。</returns>
        public static string StringJoin<T>(this IEnumerable<T> @this, char separator)
        {
            return string.Join(separator, @this);
        }
    }
}
