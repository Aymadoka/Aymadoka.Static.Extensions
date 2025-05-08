using Aymadoka.Static.FloatingPointExtension;
using Aymadoka.Static.NullableNumberExtension;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        public static string? ChineseCapitalized<T>(this T? source) where T : struct, IFloatingPoint<T>
        {
            if (!source.HasValue)
            {
                return null;
            }

            return source.Value.ToKeep().ChineseCapitalized();
        }
    }
}
