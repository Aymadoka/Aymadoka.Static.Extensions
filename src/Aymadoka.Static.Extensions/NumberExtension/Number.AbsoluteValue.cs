using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static T AbsoluteValue<T>(this T source) where T : struct, INumber<T>

        /// <summary>
        /// 返回指定 <see cref="sbyte"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="sbyte"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static sbyte AbsoluteValue(this sbyte @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="byte"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="byte"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static short AbsoluteValue(this byte @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="short"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="short"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static short AbsoluteValue(this short @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="ushort"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="ushort"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static int AbsoluteValue(this ushort @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="int"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="int"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static int AbsoluteValue(this int @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="uint"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="uint"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static long AbsoluteValue(this uint @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="long"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="long"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static long AbsoluteValue(this long @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="float"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="float"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static float AbsoluteValue(this float @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="double"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="double"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static double AbsoluteValue(this double @this)
        {
            var result = Math.Abs(@this);
            return result;
        }

        /// <summary>
        /// 返回指定 <see cref="decimal"/> 值的绝对值。
        /// </summary>
        /// <param name="this">要获取绝对值的 <see cref="decimal"/> 值。</param>
        /// <returns>绝对值。</returns>
        public static decimal AbsoluteValue(this decimal @this)
        {
            var result = Math.Abs(@this);
            return result;
        }
    }
}
