using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadok.Static.StringExtension
{
    public static class StringExtensions
    {
        public static bool IsNull([NotNullWhen(false)] this string? source)
        {
            return source == null;
        }

        public static bool IsNotNull(this string? source)
        {
            return !source.IsNull();
        }

        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? source)
        {
            return string.IsNullOrEmpty(source);
        }

        public static bool IsNotNullOrEmpty(this string? source)
        {
            return !source.IsNullOrEmpty();
        }

        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNotNullOrWhiteSpace(this string? source)
        {
            return !source.IsNullOrWhiteSpace();
        }

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

        public static bool IsEmail([NotNullWhen(true)] this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return false;
            }

            var emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(value, emailRegex, RegexOptions.IgnoreCase);
        }

        /// <summary>将字符串转换为标题大小写（每个单词首字母大写）</summary>
        public static string? ToTitleCase(this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return value;
            }

            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(value.ToLower());
        }

        /// <summary>移除字符串中的所有空格</summary>
        public static string? RemoveWhitespace(this string? value)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }

            return string.Concat(value.Where(c => !char.IsWhiteSpace(c)));
        }

        /// <summary>截取字符串的左侧指定长度的子字符串</summary>
        public static string? Left(this string? value, int length)
        {
            if (value.IsNullOrEmpty() || length <= 0)
            {
                return string.Empty;
            }

            return value.Length <= length ? value : value.Substring(0, length);
        }

        /// <summary>截取字符串的右侧指定长度的子字符串</summary>
        public static string Right(this string value, int length)
        {
            if (value.IsNullOrEmpty() || length <= 0)
            {
                return string.Empty;
            }

            return value.Length <= length ? value : value.Substring(value.Length - length);
        }

        /// <summary>将字符串转换为 Base64 编码</summary>
        public static string ToBase64(this string value)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }

            var bytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>从 Base64 编码的字符串解码</summary>
        public static string FromBase64(this string value)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }

            var bytes = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>检查字符串是否为数字</summary>
        public static bool IsNumeric(this string value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return false;
            }

            return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        }

        /// <summary>将字符串的首字母大写</summary>
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
