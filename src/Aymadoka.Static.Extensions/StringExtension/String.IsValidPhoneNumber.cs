using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>验证字符串是否为有效的电话号码</summary>
        /// <param name="value">要验证的字符串</param>
        /// <returns>如果字符串是有效的电话号码，则返回 true；否则返回 false</returns>
        public static bool IsValidPhoneNumber(this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return false;
            }
            const string phoneRegex = @"^(\+?\d{1,3}[- ]?)?(\d{1,4}[- ]?)?\d{3,4}[- ]?\d{3,9}$";

            return Regex.IsMatch(value, phoneRegex, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }
    }
}
