namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsNegativeInfinity<T>(this T d) where T : struct, INumber<T>

        public static bool IsNegativeInfinity(this float @this)
        {
            return float.IsNegativeInfinity(@this);
        }

        public static bool IsNegativeInfinity(this double @this)
        {
            return double.IsNegativeInfinity(@this);
        }
    }
}
