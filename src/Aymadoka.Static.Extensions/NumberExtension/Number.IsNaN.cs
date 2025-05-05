using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        public static bool IsNaN<T>(this T d) where T : struct, INumber<T>
        {
            return T.IsNaN(d);
        }
    }
}
