using System.Linq;
using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断字符串是否为回文字符串（忽略非字母数字字符，区分大小写）。
        /// </summary>
        /// <param name="this">要判断的字符串。</param>
        /// <returns>如果是回文字符串返回 true，否则返回 false。</returns>
        public static bool IsPalindrome(this string @this)
        {
            // 仅保留字母和数字字符
            var rgx = new Regex("[^a-zA-Z0-9]");
            @this = rgx.Replace(@this, "");
            var result = @this.SequenceEqual(@this.Reverse());
            return result;
        }
    }
}
