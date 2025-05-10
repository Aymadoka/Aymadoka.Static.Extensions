using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static T AbsoluteValue<T>(this T source) where T : struct, INumber<T>

        public static sbyte AbsoluteValue(this sbyte @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static short AbsoluteValue(this byte @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static short AbsoluteValue(this short @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static int AbsoluteValue(this ushort @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static int AbsoluteValue(this int @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static long AbsoluteValue(this uint @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static long AbsoluteValue(this long @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static float AbsoluteValue(this float @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static double AbsoluteValue(this double @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        public static decimal AbsoluteValue(this decimal @this)
        {
            var result = Math.Abs(@this);
            return result;
        }
    }
}
