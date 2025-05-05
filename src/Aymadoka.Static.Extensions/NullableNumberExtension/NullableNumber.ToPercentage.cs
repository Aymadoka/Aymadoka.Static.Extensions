using Aymadoka.Static.FloatingPointExtension;
using System.Globalization;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension;

public static partial class NullableNumberExtensions
{
    public static string? ToPercentage<T>(this T? source, int decimalPlaces = 2) where T : struct, IFloatingPoint<T>
    {
        return source.ToPercentage(decimalPlaces, null);
    }

    public static string? ToPercentage<T>(this T? source, int decimalPlaces, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>
    {
        if (!source.HasValue)
        {
            return null;
        }

        var result = source.Value.ToPercentage(decimalPlaces, culture);
        return result;
    }
}
