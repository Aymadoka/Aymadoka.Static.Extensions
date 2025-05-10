namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsPositive<T>(this T source) where T : struct, INumber<T>

        public static bool IsPositive(this sbyte @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this byte @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this short @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this ushort @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this int @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this uint @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this long @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this ulong @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this float @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this double @this)
        {
            return @this > 0;
        }

        public static bool IsPositive(this decimal @this)
        {
            return @this > 0;
        }
    }
}
