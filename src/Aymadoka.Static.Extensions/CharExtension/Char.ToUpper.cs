using System.Globalization;

namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static char ToUpper(this char c, CultureInfo culture)
    {
        return char.ToUpper(c, culture);
    }

    public static char ToUpper(this char c)
    {
        return char.ToUpper(c);
    }
}
