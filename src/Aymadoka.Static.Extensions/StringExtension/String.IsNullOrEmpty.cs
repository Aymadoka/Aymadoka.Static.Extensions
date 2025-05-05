using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>判断字符串是否为 null 或空字符串</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串为 null 或空字符串，则返回 true；否则返回 false</returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? source)
        {
            return string.IsNullOrEmpty(source);
        }
    }
}
