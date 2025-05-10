using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static bool IsAlpha(this string @this)
        {
            var result = !Regex.IsMatch(@this, "[^a-zA-Z]");
            return result;
        }
    }
}
