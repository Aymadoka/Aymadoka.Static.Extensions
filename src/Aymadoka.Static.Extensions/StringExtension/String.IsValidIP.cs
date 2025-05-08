using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static bool IsValidIP([NotNullWhen(true)] this string? @this)
    {
        if (@this.IsNullOrWhiteSpace())
        {
            return false;
        }

        var emailRegex = @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$";
        return Regex.IsMatch(@this, emailRegex);
    }
}
