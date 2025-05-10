using System.Globalization;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        public static UnicodeCategory GetUnicodeCategory(this char c)
        {
            return char.GetUnicodeCategory(c);
        }
    }
}
