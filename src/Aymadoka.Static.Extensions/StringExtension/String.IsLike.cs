using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断字符串是否与指定的模式匹配。模式支持通配符：
        /// * 匹配任意数量的任意字符，? 匹配任意单个字符，# 匹配任意单个数字，
        /// [abc] 匹配集合中的任意单个字符，[!abc] 匹配不在集合中的任意单个字符。
        /// </summary>
        /// <param name="this">要匹配的字符串。</param>
        /// <param name="pattern">用于匹配的模式字符串。</param>
        /// <returns>如果字符串与模式匹配，则为 true；否则为 false。</returns>
        public static bool IsLike(this string @this, string pattern)
        {
            // Turn the pattern into regex pattern, and match the whole string with ^$
            string regexPattern = "^" + Regex.Escape(pattern) + "$";

            // Escape special character ?, #, *, [], and [!]
            regexPattern = regexPattern.Replace(@"\[!", "[^")
                .Replace(@"\[", "[")
                .Replace(@"\]", "]")
                .Replace(@"\?", ".")
                .Replace(@"\*", ".*")
                .Replace(@"\#", @"\d");

            return Regex.IsMatch(@this, regexPattern);
        }
    }
}
