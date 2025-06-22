using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 使用指定的正则表达式模式在输入字符串中查找所有匹配项。
        /// </summary>
        /// <param name="input">要搜索的输入字符串。</param>
        /// <param name="pattern">要匹配的正则表达式模式。</param>
        /// <returns>匹配项的集合。</returns>
        public static MatchCollection Matches(this string input, string pattern)
        {
            return Regex.Matches(input, pattern);
        }

        /// <summary>
        /// 使用指定的正则表达式模式和选项在输入字符串中查找所有匹配项。
        /// </summary>
        /// <param name="input">要搜索的输入字符串。</param>
        /// <param name="pattern">要匹配的正则表达式模式。</param>
        /// <param name="options">正则表达式选项。</param>
        /// <returns>匹配项的集合。</returns>
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options)
        {
            return Regex.Matches(input, pattern, options);
        }
    }
}
