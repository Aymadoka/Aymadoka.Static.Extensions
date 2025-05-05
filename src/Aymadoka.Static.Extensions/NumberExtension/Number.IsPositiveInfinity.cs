using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        public static bool IsPositiveInfinity<T>(this T d) where T : struct, INumber<T>
        {
            return T.IsPositiveInfinity(d);
        }
    }
}
