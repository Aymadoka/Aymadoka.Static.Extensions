using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 移除字符串中的所有字母字符（包括大写和小写字母）。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <returns>移除所有字母后的新字符串。</returns>
        public static string RemoveLetter(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => !char.IsLetter(x)).ToArray());
        }
    }
}
