using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsInteger<T>(this T source) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <see cref="sbyte"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this sbyte @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="byte"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this byte @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="short"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this short @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="ushort"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this ushort @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="int"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this int @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="uint"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this uint @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="long"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this long @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="ulong"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this ulong @this)
        {
            return @this % 1 == 0;
        }

        /// <summary>
        /// 判断 <see cref="float"/> 是否为整数。
        /// </summary>
        /// <param name="this">要判断的浮点数。</param>
        /// <returns>如果为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this float @this)
        {
            // 定义一个小的容差值
            const float epsilon = 1e-6f;
            return Math.Abs(@this % 1) < epsilon;
        }

        /// <summary>
        /// 判断 <see cref="double"/> 是否为整数。
        /// </summary>
        /// <param name="this">要判断的双精度浮点数。</param>
        /// <returns>如果为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this double @this)
        {
            // 定义一个小的容差值
            const double epsilon = 1e-9;
            return Math.Abs(@this % 1) < epsilon;
        }

        /// <summary>
        /// 判断 <see cref="decimal"/> 是否为整数。
        /// </summary>
        public static bool IsInteger(this decimal @this)
        {
            return @this % 1 == 0;
        }
    }
}
