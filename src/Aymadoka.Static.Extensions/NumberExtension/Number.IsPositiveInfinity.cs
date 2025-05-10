namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsPositiveInfinity<T>(this T d) where T : struct, INumber<T>

        public static bool IsPositiveInfinity(this float @this)
        {
            return float.IsPositiveInfinity(@this);
        }

        public static bool IsPositiveInfinity(this double @this)
        {
            return double.IsPositiveInfinity(@this);
        }
    }
}
