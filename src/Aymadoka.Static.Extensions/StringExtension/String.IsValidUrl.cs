using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>验证字符串是否为有效的 URL</summary>
        /// <param name="url">要验证的字符串</param>
        /// <returns>如果字符串是有效的 URL，则返回 true；否则返回 false</returns>
        public static bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }
    }
}
