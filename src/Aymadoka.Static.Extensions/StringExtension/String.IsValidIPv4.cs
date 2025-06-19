using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断字符串是否为有效的IPv4地址。
        /// </summary>
        /// <param name="this">要验证的字符串。</param>
        /// <returns>如果是有效的IPv4地址，返回 true；否则返回 false。</returns>
        public static bool IsValidIPv4([NotNullWhen(true)] this string? @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return false;
            }

            // 正则表达式匹配IPv4地址
            const string pattern = @"^(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)){3}$";
            return Regex.IsMatch(@this, pattern);
        }
    }
}
