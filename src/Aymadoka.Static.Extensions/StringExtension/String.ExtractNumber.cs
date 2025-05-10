using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string ExtractNumber(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => char.IsNumber(x)).ToArray());
        }
    }
}
