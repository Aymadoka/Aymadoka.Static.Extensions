using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.StringExtension
{
    public static class StringExtensions
    {
        /// <summary>判断字符串是否为 null</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串为 null，则返回 true；否则返回 false</returns>
        public static bool IsNull([NotNullWhen(false)] this string? source)
        {
            return source == null; 
        }

        /// <summary>判断字符串是否不为 null</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串不为 null，则返回 true；否则返回 false</returns>
        public static bool IsNotNull([NotNullWhen(true)] this string? source)
        {
            return !source.IsNull();
        }

        /// <summary>判断字符串是否为 null 或空字符串</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串为 null 或空字符串，则返回 true；否则返回 false</returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? source)
        {
            return string.IsNullOrEmpty(source);
        }

        /// <summary>判断字符串是否不为 null 且不为空字符串</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串不为 null 且不为空字符串，则返回 true；否则返回 false</returns>
        public static bool IsNotNullOrEmpty(this string? source)
        {
            return !source.IsNullOrEmpty();
        }

        /// <summary>判断字符串是否为 null 或仅包含空白字符</summary>
        /// <param name="value">要检查的字符串</param>
        /// <returns>如果字符串为 null 或仅包含空白字符，则返回 true；否则返回 false</returns>
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>判断字符串是否不为 null 且不全为空白字符</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串不为 null 且不全为空白字符，则返回 true；否则返回 false</returns>
        public static bool IsNotNullOrWhiteSpace(this string? source)
        {
            return !source.IsNullOrWhiteSpace();
        }

        /// <summary>反转字符串</summary>
        /// <param name="value">要反转的字符串</param>
        /// <returns>反转后的字符串；如果输入为 null 或仅包含空白字符，则返回原字符串</returns>
        public static string? Reverse(this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return value;
            }

            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);

            return reversed;
        }

        /// <summary>验证字符串是否为有效的电子邮件地址</summary>
        /// <param name="value">要验证的字符串</param>
        /// <returns>如果字符串是有效的电子邮件地址，则返回 true；否则返回 false</returns>
        public static bool IsValidEmail([NotNullWhen(true)] this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return false;
            }

            var emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(value, emailRegex, RegexOptions.IgnoreCase);
        }

        /// <summary>验证字符串是否为有效的电话号码</summary>
        /// <param name="value">要验证的字符串</param>
        /// <returns>如果字符串是有效的电话号码，则返回 true；否则返回 false</returns>
        public static bool IsValidPhoneNumber(this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return false;
            }
            const string phoneRegex = @"^(\+?\d{1,3}[- ]?)?(\d{1,4}[- ]?)?\d{3,4}[- ]?\d{4,9}$";

            return Regex.IsMatch(value, phoneRegex, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        /// <summary>验证字符串是否为有效的 URL</summary>
        /// <param name="url">要验证的字符串</param>
        /// <returns>如果字符串是有效的 URL，则返回 true；否则返回 false</returns>
        public static bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }

        /// <summary>将字符串转换为标题格式（每个单词首字母大写）</summary>
        /// <param name="value">要转换的字符串</param>
        /// <returns>转换后的字符串；如果输入为 null 或仅包含空白字符，则返回原字符串</returns>
        public static string? ToTitleCase(this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return value;
            }

            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(value.ToLower());
        }

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

        /// <summary>获取字符串左侧指定长度的子字符串</summary>
        /// <param name="value">要处理的字符串</param>
        /// <param name="length">要获取的子字符串长度</param>
        /// <returns>左侧指定长度的子字符串；如果输入为 null 或长度无效，则返回空字符串</returns>
        public static string? Left(this string? value, int length)
        {
            if (value.IsNullOrEmpty() || length <= 0)
            {
                return string.Empty;
            }

            return value.Length <= length ? value : value.Substring(0, length);
        }

        /// <summary>获取字符串右侧指定长度的子字符串</summary>
        /// <param name="value">要处理的字符串</param>
        /// <param name="length">要获取的子字符串长度</param>
        /// <returns>右侧指定长度的子字符串；如果输入为 null 或长度无效，则返回空字符串</returns>
        public static string Right(this string value, int length)
        {
            if (value.IsNullOrEmpty() || length <= 0)
            {
                return string.Empty;
            }

            return value.Length <= length ? value : value.Substring(value.Length - length);
        }

        /// <summary>判断字符串是否为数字</summary>
        /// <param name="value">要检查的字符串</param>
        /// <returns>如果字符串是数字，则返回 true；否则返回 false</returns>
        public static bool IsNumeric(this string value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return false;
            }

            return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        }

        /// <summary>将字符串的首字母大写</summary>
        /// <param name="value">要处理的字符串</param>
        /// <returns>首字母大写的字符串；如果输入为 null 或空字符串，则返回原字符串</returns>
        public static string Capitalize(this string value)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }

            return char.ToUpper(value[0]) + value.Substring(1);
        }
    }
}
