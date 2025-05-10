using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsInteger<T>(this T source) where T : struct, INumber<T>

        public static bool IsInteger(this sbyte @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this byte @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this short @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this ushort @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this int @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this uint @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this long @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this ulong @this)
        {
            return @this % 1 == 0;
        }

        public static bool IsInteger(this float @this)
        {
            // 定义一个小的容差值
            const float epsilon = 1e-6f;
            return Math.Abs(@this % 1) < epsilon;
        }

        public static bool IsInteger(this double @this)
        {
            // 定义一个小的容差值
            const double epsilon = 1e-9;
            return Math.Abs(@this % 1) < epsilon;
        }

        public static bool IsInteger(this decimal @this)
        {
            return @this % 1 == 0;
        }
    }
}
