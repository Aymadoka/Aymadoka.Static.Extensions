using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断输入字符串是否与指定的正则表达式模式匹配。
        /// </summary>
        /// <param name="input">要匹配的输入字符串。</param>
        /// <param name="pattern">正则表达式模式。</param>
        /// <returns>如果匹配则为 true，否则为 false。</returns>
        public static bool IsMatch(this string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

        /// <summary>
        /// 判断输入字符串是否与指定的正则表达式模式和选项匹配。
        /// </summary>
        /// <param name="input">要匹配的输入字符串。</param>
        /// <param name="pattern">正则表达式模式。</param>
        /// <param name="options">正则表达式选项。</param>
        /// <returns>如果匹配则为 true，否则为 false。</returns>
        public static bool IsMatch(this string input, string pattern, RegexOptions options)
        {
            return Regex.IsMatch(input, pattern, options);
        }
    }
}
