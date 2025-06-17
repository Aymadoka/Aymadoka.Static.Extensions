using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断当前字符串是否包含所有指定的子字符串（区分大小写）。
        /// </summary>
        /// <param name="this">要检查的字符串。</param>
        /// <param name="values">要查找的子字符串数组。</param>
        /// <returns>如果全部包含则返回 true，否则返回 false。</returns>
        public static bool ContainsAll(this string @this, params string[] values)
        {
            foreach (string value in values)
            {
                if (@this.IndexOf(value) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断当前字符串是否包含所有指定的子字符串（可指定字符串比较方式）。
        /// </summary>
        /// <param name="this">要检查的字符串。</param>
        /// <param name="comparisonType">字符串比较方式。</param>
        /// <param name="values">要查找的子字符串数组。</param>
        /// <returns>如果全部包含则返回 true，否则返回 false。</returns>
        public static bool ContainsAll(this string @this, StringComparison comparisonType, params string[] values)
        {
            foreach (string value in values)
            {
                if (@this.IndexOf(value, comparisonType) == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
