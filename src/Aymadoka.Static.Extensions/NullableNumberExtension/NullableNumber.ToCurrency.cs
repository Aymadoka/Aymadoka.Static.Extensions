using Aymadoka.Static.FloatingPointExtension;
using System.Globalization;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension;

public static partial class NullableNumberExtensions
{
    /// <summary>将小数值格式化为货币字符串</summary>
    /// <param name="source">需要格式化的原始小数值</param>
    /// <param name="culture">指定的区域文化，默认为 "zh-CN"</param>
    /// <returns>格式化后的货币字符串</returns>
    public static string? ToCurrency<T>(this T? source, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>
    {
        if (!source.HasValue)
        {
            return null;
        }

        var result = source.Value.ToCurrency();
        return result;
    }
}
