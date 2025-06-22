using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 移除字符串中的所有数字字符。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <returns>移除所有数字后的新字符串。</returns>
        public static string RemoveNumber(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => !char.IsNumber(x)).ToArray());
        }
    }
}
