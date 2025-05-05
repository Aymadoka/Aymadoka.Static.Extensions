using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        public static bool InRange<T>(this T @this, T minValue, T maxValue) where T : struct, INumber<T>
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }
    }
}
