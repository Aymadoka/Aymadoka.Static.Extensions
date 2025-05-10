using Aymadoka.Static.FloatingPointExtension;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        public static T? Keep<T>(this T? source, int keepPlaceCount = 2) where T : struct, IFloatingPoint<T>
        {
            if (!source.HasValue)
            {
                return null;
            }

            T value = source.Value.ToKeep(keepPlaceCount);
            return value;
        }
    }
}
