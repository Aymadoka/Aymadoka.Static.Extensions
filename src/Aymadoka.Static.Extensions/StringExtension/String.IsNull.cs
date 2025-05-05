using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>判断字符串是否为 null</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串为 null，则返回 true；否则返回 false</returns>
        public static bool IsNull([NotNullWhen(false)] this string? source)
        {
            return source == null;
        }
    }
}
