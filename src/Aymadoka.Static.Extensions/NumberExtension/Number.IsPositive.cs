namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsPositive<T>(this T source) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <see cref="sbyte"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this sbyte @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="byte"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this byte @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="short"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this short @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="ushort"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this ushort @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="int"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this int @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="uint"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this uint @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="long"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this long @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="ulong"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this ulong @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="float"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this float @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="double"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this double @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// 判断 <see cref="decimal"/> 是否为正数。
        /// </summary>
        /// <param name="this">要判断的值。</param>
        /// <returns>如果为正数，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPositive(this decimal @this)
        {
            return @this > 0;
        }
    }
}
