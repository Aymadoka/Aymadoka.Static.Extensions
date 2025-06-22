using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 提取字符串中的所有字母字符，返回由这些字母组成的新字符串。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <returns>仅包含字母字符的新字符串。</returns>
        public static string ExtractLetter(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => char.IsLetter(x)).ToArray());
        }
    }
}
