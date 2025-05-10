using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>移除字符串中的所有空白字符</summary>
        /// <param name="value">要处理的字符串</param>
        /// <returns>移除空白字符后的字符串；如果输入为 null 或空字符串，则返回原字符串</returns>
        public static string? RemoveWhitespace(this string? value)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }

            return string.Concat(value.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}
