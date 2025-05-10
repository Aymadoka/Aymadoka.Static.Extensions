namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsInfinity<T>(this T d) where T : struct, INumber<T>

        public static bool IsInfinity(this float @this)
        {
            return float.IsInfinity(@this);
        }

        public static bool IsInfinity(this double @this)
        {
            return double.IsInfinity(@this);
        }
    }
}
