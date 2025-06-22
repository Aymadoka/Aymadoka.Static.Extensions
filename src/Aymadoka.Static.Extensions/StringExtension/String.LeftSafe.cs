using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 返回字符串左侧指定长度的子字符串。如果长度超过原字符串长度，则返回整个字符串。
        /// </summary>
        /// <param name="this">要截取的字符串。</param>
        /// <param name="length">要返回的子字符串长度。</param>
        /// <returns>左侧指定长度的子字符串，或整个字符串（如果长度超出范围）。</returns>
        public static string LeftSafe(this string @this, int length)
        {
            return @this.Substring(0, Math.Min(length, @this.Length));
        }
    }
}
