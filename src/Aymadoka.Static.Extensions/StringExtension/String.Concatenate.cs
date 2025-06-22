using System;
using System.Collections.Generic;
using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串集合中的所有字符串连接为一个新字符串。
        /// </summary>
        /// <param name="this">要连接的字符串集合。</param>
        /// <returns>连接后的字符串。</returns>
        public static string Concatenate(this IEnumerable<string> @this)
        {
            var sb = new StringBuilder();

            foreach (var s in @this)
            {
                sb.Append(s);
            }

            return sb.ToString();
        }

        /// <summary>
        /// 将集合中的每个元素通过指定的转换函数转换为字符串后连接为一个新字符串。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="source">要连接的集合。</param>
        /// <param name="func">将元素转换为字符串的函数。</param>
        /// <returns>连接后的字符串。</returns>
        public static string Concatenate<T>(this IEnumerable<T> source, Func<T, string> func)
        {
            var sb = new StringBuilder();
            foreach (var item in source)
            {
                sb.Append(func(item));
            }

            return sb.ToString();
        }
    }
}
