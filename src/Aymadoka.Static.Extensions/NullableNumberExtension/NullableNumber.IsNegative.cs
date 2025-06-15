using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        //  static bool IsNegative<T>(this T? source) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <see cref="sbyte?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 sbyte 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this sbyte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="byte?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 byte 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="short?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 short 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this short? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="ushort?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 ushort 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="int?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 int 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this int? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="uint?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 uint 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="long?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 long 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this long? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="ulong?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 ulong 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this ulong? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="float?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 float 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this float? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="double?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 double 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this double? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="decimal?"/> 是否为负数。
        /// </summary>
        /// <param name="this">可空 decimal 值。</param>
        /// <returns>如果为负数则返回 true，否则返回 false。</returns>
        public static bool IsNegative(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }
    }
}
