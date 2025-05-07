using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static MatchCollection Matches(this string input, string pattern)
    {
        return Regex.Matches(input, pattern);
    }

    public static MatchCollection Matches(this string input, string pattern, RegexOptions options)
    {
        return Regex.Matches(input, pattern, options);
    }
}
