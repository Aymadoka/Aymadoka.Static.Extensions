using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断字符串是否为纯数字（仅包含0-9）。
        /// </summary>
        /// <param name="this">要判断的字符串。</param>
        /// <returns>如果字符串为纯数字则返回 true，否则返回 false。</returns>
        public static bool IsNumeric(this string @this)
        {
            if (@this.IsNullOrWhiteSpace())
            {
                return false;
            }

            var result = Regex.IsMatch(@this, @"^\d+$");
            return result;
        }
    }
}
