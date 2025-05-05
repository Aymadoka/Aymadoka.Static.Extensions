using Aymadoka.Static.NumberExtension;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension;

public static partial class NullableNumberExtensions
{
    public static bool IsInteger<T>(this T? source) where T : struct, INumber<T>
    {
        if (!source.HasValue)
        {
            return false;
        }

        return source.Value.IsInteger();
    }
}
