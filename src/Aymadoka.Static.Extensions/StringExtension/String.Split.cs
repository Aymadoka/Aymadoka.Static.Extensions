using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 按指定字符串分隔符拆分当前字符串，并返回子字符串数组。
        /// </summary>
        /// <param name="this">要拆分的字符串实例。</param>
        /// <param name="separator">用作分隔符的字符串。</param>
        /// <param name="option">指定是否省略返回数组中的空项。</param>
        /// <returns>由此实例中的子字符串组成的数组。</returns>
        public static string[] Split(this string @this, string separator, StringSplitOptions option = StringSplitOptions.None)
        {
            return @this.Split(new[] { separator }, option);
        }
    }
}
