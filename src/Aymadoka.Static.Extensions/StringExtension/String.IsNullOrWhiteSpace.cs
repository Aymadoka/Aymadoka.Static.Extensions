using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断指定的字符串是否为 <c>null</c>、空字符串或仅包含空白字符。
        /// </summary>
        /// <param name="value">要检查的字符串。</param>
        /// <returns>如果 <paramref name="value"/> 为 <c>null</c>、空字符串或仅包含空白字符，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
