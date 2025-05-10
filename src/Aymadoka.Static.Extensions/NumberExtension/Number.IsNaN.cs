namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        //  static bool IsNaN<T>(this T d) where T : struct, INumber<T>

        public static bool IsNaN(this float @this)
        {
            return float.IsNaN(@this);
        }

        public static bool IsNaN(this double @this)
        {
            return double.IsNaN(@this);
        }
    }
}
