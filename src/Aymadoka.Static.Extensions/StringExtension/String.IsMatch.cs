using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static bool IsMatch(this string input, string pattern)
    {
        return Regex.IsMatch(input, pattern);
    }

    public static bool IsMatch(this string input, string pattern, RegexOptions options)
    {
        return Regex.IsMatch(input, pattern, options);
    }
}
