using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static bool IsInteger<T>(this T? source) where T : struct, INumber<T>

        /// <summary>
        /// 判断可空 <see cref="sbyte"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 sbyte 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this sbyte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="byte"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 byte 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="short"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 short 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this short? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="ushort"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 ushort 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="int"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 int 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this int? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="uint"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 uint 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="long"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 long 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this long? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="ulong"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 ulong 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this ulong? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="float"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 float 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this float? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="double"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 double 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this double? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        /// <summary>
        /// 判断可空 <see cref="decimal"/> 是否为整数。
        /// </summary>
        /// <param name="this">可空 decimal 值。</param>
        /// <returns>如果有值且为整数则返回 true，否则返回 false。</returns>
        public static bool IsInteger(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }
    }
}
