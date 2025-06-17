using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断指定字符串是否包含指定的子字符串。
        /// </summary>
        /// <param name="this">要搜索的字符串。</param>
        /// <param name="value">要查找的子字符串。</param>
        /// <returns>如果找到子字符串，则为 true；否则为 false。</returns>
        public static bool Contains(this string @this, string value)
        {
            return @this.IndexOf(value) != -1;
        }

        /// <summary>
        /// 使用指定的字符串比较方式判断字符串是否包含指定的子字符串。
        /// </summary>
        /// <param name="this">要搜索的字符串。</param>
        /// <param name="value">要查找的子字符串。</param>
        /// <param name="comparisonType">字符串比较方式。</param>
        /// <returns>如果找到子字符串，则为 true；否则为 false。</returns>
        public static bool Contains(this string @this, string value, StringComparison comparisonType)
        {
            return @this.IndexOf(value, comparisonType) != -1;
        }
    }
}
