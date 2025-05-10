using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsZero<T>(this T source) where T : struct, INumber<T>

        public static bool IsZero(this sbyte @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this byte @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this short @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this ushort @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this int @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this uint @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this long @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this ulong @this)
        {
            return @this == 0;
        }

        public static bool IsZero(this float @this)
        {
            // 定义一个小的容差值
            const float epsilon = 1e-6f;
            return Math.Abs(@this) < epsilon;
        }

        public static bool IsZero(this double @this)
        {
            // 定义一个小的容差值
            const double epsilon = 1e-9; 
            return Math.Abs(@this) < epsilon;
        }

        public static bool IsZero(this decimal @this)
        {
            return @this == 0;
        }
    }
}
