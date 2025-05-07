using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
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
}
