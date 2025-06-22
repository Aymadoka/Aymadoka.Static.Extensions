using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断指定的字符串是否为 <c>null</c> 或空字符串。
        /// </summary>
        /// <param name="source">要检查的字符串。</param>
        /// <returns>如果 <paramref name="source"/> 为 <c>null</c> 或空字符串，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? source)
        {
            return string.IsNullOrEmpty(source);
        }
    }
}
