namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsNegative<T>(this T source) where T : struct, INumber<T>

        public static bool IsNegative(this sbyte @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this byte @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this short @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this ushort @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this int @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this uint @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this long @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this ulong @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this float @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this double @this)
        {
            return @this < 0;
        }

        public static bool IsNegative(this decimal @this)
        {
            return @this < 0;
        }
    }
}
