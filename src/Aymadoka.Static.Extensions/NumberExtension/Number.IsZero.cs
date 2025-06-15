using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsZero<T>(this T source) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <see cref="sbyte"/> 是否为零。
        /// </summary>
        public static bool IsZero(this sbyte @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="byte"/> 是否为零。
        /// </summary>
        public static bool IsZero(this byte @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="short"/> 是否为零。
        /// </summary>
        public static bool IsZero(this short @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="ushort"/> 是否为零。
        /// </summary>
        public static bool IsZero(this ushort @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="int"/> 是否为零。
        /// </summary>
        public static bool IsZero(this int @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="uint"/> 是否为零。
        /// </summary>
        public static bool IsZero(this uint @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="long"/> 是否为零。
        /// </summary>
        public static bool IsZero(this long @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="ulong"/> 是否为零。
        /// </summary>
        public static bool IsZero(this ulong @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// 判断 <see cref="float"/> 是否为零，使用容差值 <c>1e-6</c>。
        /// </summary>
        public static bool IsZero(this float @this)
        {
            // 定义一个小的容差值
            const float epsilon = 1e-6f;
            return Math.Abs(@this) < epsilon;
        }

        /// <summary>
        /// 判断 <see cref="double"/> 是否为零，使用容差值 <c>1e-9</c>。
        /// </summary>
        public static bool IsZero(this double @this)
        {
            // 定义一个小的容差值
            const double epsilon = 1e-9;
            return Math.Abs(@this) < epsilon;
        }

        /// <summary>
        /// 判断 <see cref="decimal"/> 是否为零。
        /// </summary>
        public static bool IsZero(this decimal @this)
        {
            return @this == 0;
        }
    }
}
