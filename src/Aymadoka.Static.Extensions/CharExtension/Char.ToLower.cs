using System.Globalization;
using System;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        public static char ToLower(this char c, CultureInfo culture)
        {
            return char.ToLower(c, culture);
        }

        public static char ToLower(this char c)
        {
            return char.ToLower(c);
        }
    }
}
