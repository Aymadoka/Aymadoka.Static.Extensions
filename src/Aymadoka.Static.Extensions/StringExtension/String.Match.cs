using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static Match Match(this string input, string pattern)
        {
            return Regex.Match(input, pattern);
        }

        public static Match Match(this string input, string pattern, RegexOptions options)
        {
            return Regex.Match(input, pattern, options);
        }
    }
}
