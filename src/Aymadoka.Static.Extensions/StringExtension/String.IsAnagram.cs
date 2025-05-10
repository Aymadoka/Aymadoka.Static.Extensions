using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static bool IsAnagram(this string @this, string otherString)
        {
            var result = @this
                .OrderBy(c => c)
                .SequenceEqual(otherString.OrderBy(c => c));
            return result;
        }
    }
}
