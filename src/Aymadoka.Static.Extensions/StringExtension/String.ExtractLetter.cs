using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string ExtractLetter(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => char.IsLetter(x)).ToArray());
        }
    }
}
