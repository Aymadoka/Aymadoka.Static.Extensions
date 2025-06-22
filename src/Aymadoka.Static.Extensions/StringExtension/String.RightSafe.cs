using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 返回字符串右侧指定长度的子字符串。如果长度超过原字符串长度，则返回整个字符串。
        /// </summary>
        /// <param name="this">要操作的字符串。</param>
        /// <param name="length">要获取的右侧子字符串长度。</param>
        /// <returns>右侧指定长度的子字符串。</returns>
        public static string RightSafe(this string @this, int length)
        {
            return @this.Substring(Math.Max(0, @this.Length - length));
        }
    }
}
