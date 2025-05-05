using Aymadoka.Static.FloatingPointExtension;
using System.Globalization;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension;

public static partial class NullableNumberExtensions
{
    /// <summary>将小数值转换为科学计数法格式的字符串</summary>
    /// <param name="source">需要转换的原始小数值</param>
    /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
    /// <returns>转换后的科学计数法字符串</returns>
    public static string? ToScientificNotation<T>(this T? source, int decimalPlaces = 2) where T : struct, IFloatingPoint<T>
    {
        return source.ToScientificNotation(decimalPlaces, null);
    }

    public static string? ToScientificNotation<T>(this T? source, int decimalPlaces, CultureInfo? culture) where T : struct, IFloatingPoint<T>
    {
        if (!source.HasValue)
        {
            return null;
        }

        return source.Value.ToScientificNotation(decimalPlaces, culture);
    }
}
