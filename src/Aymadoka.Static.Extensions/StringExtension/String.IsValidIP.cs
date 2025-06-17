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
            if (@this.IsNullOrWhiteSpace())
            {
                return false;
            }

            // 匹配IPv4地址的正则表达式
            var emailRegex = @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$";
            return Regex.IsMatch(@this, emailRegex);
        }
    }
}
