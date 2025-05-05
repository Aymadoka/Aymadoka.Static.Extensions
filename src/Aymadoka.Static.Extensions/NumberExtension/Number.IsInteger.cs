using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        public static bool IsInteger<T>(this T source) where T : struct, INumber<T>
        {
            return source % T.One == T.Zero;
        }
    }
}
