using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 使用指定的正则表达式模式在输入字符串中搜索第一个匹配项。
        /// </summary>
        /// <param name="input">要搜索的输入字符串。</param>
        /// <param name="pattern">要匹配的正则表达式模式。</param>
        /// <returns>第一个匹配项的 <see cref="Match"/> 对象。</returns>
        public static Match Match(this string input, string pattern)
        {
            return Regex.Match(input, pattern);
        }

        /// <summary>
        /// 使用指定的正则表达式模式和选项在输入字符串中搜索第一个匹配项。
        /// </summary>
        /// <param name="input">要搜索的输入字符串。</param>
        /// <param name="pattern">要匹配的正则表达式模式。</param>
        /// <param name="options">正则表达式选项。</param>
        /// <returns>第一个匹配项的 <see cref="Match"/> 对象。</returns>
        public static Match Match(this string input, string pattern, RegexOptions options)
        {
            return Regex.Match(input, pattern, options);
        }
    }
}
