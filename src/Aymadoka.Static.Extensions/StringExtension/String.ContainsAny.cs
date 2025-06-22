using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断当前字符串是否包含指定的任意一个子字符串。
        /// </summary>
        /// <param name="this">要搜索的字符串。</param>
        /// <param name="values">要查找的子字符串数组。</param>
        /// <returns>如果包含任意一个子字符串，则返回 true；否则返回 false。</returns>
        public static bool ContainsAny(this string @this, params string[] values)
        {
            foreach (string value in values)
            {
                if (@this.IndexOf(value) != -1)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 判断当前字符串是否包含指定的任意一个子字符串，使用指定的字符串比较方式。
        /// </summary>
        /// <param name="this">要搜索的字符串。</param>
        /// <param name="comparisonType">字符串比较方式。</param>
        /// <param name="values">要查找的子字符串数组。</param>
        /// <returns>如果包含任意一个子字符串，则返回 true；否则返回 false。</returns>
        public static bool ContainsAny(this string @this, StringComparison comparisonType, params string[] values)
        {
            foreach (string value in values)
            {
                if (@this.IndexOf(value, comparisonType) != -1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
