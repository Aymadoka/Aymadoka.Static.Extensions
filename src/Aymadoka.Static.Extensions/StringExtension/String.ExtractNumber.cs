using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 提取字符串中的所有数字字符，并以新字符串形式返回。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <returns>仅包含原字符串中数字字符的新字符串。</returns>
        public static string ExtractNumber(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => char.IsNumber(x)).ToArray());
        }
    }
}
