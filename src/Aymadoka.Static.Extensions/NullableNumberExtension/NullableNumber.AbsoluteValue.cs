using Aymadoka.Static.NumberExtension;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension;

public static partial class NullableNumberExtensions
{
    /// <summary>获取小数值的绝对值</summary>
    /// <param name="source">需要处理的原始小数值</param>
    /// <returns>小数值的绝对值</returns>
    public static T? AbsoluteValue<T>(this T? source) where T : struct, INumber<T>
    {
        if (!source.HasValue)
        {
            return source;
        }

        return source.Value.AbsoluteValue();
    }
}
