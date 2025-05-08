using System.Linq;
using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static bool IsPalindrome(this string @this)
    {
        // Keep only alphanumeric characters
        var rgx = new Regex("[^a-zA-Z0-9]");
        @this = rgx.Replace(@this, "");
        var result = @this.SequenceEqual(@this.Reverse());
        return result;
    }
}
