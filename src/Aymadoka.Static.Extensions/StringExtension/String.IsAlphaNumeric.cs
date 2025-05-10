using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static bool IsAlphaNumeric(this string @this)
        {
            var result = !Regex.IsMatch(@this, "[^a-zA-Z0-9]");
            return result;
        }
    }
}
