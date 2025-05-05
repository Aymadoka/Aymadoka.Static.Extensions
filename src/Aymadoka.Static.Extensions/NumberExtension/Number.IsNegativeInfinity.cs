using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        public static bool IsNegativeInfinity<T>(this T d) where T : struct, INumber<T>
        {
            return T.IsNegativeInfinity(d);
        }
    }
}
