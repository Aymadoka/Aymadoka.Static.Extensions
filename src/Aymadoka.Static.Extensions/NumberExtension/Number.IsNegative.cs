namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsNegative<T>(this T source) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <see cref="sbyte"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this sbyte @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="byte"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this byte @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="short"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this short @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="ushort"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this ushort @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="int"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this int @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="uint"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this uint @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="long"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this long @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="ulong"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this ulong @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="float"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this float @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="double"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this double @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// 判断 <see cref="decimal"/> 是否为负数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this decimal @this)
        {
            return @this < 0;
        }
    }
}
