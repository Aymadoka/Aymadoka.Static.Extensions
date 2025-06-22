using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断字符串是否只包含英文字母（a-zA-Z）。
        /// </summary>
        /// <param name="this">要检查的字符串。</param>
        /// <returns>如果字符串只包含英文字母则返回 true，否则返回 false。</returns>
        public static bool IsAlpha(this string @this)
        {
            var result = !Regex.IsMatch(@this, "[^a-zA-Z]");
            return result;
        }
    }
}
