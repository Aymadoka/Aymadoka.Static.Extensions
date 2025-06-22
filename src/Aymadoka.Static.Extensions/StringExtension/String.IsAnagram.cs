using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断当前字符串与另一个字符串是否为变位词（字母异位词）。
        /// </summary>
        /// <param name="this">当前字符串。</param>
        /// <param name="otherString">要比较的另一个字符串。</param>
        /// <returns>如果两个字符串为变位词，则返回 true；否则返回 false。</returns>
        public static bool IsAnagram(this string @this, string otherString)
        {
            var result = @this
                .OrderBy(c => c)
                .SequenceEqual(otherString.OrderBy(c => c));
            return result;
        }
    }
}
