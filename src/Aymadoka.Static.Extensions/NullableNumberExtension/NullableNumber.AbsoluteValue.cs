using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static T? AbsoluteValue<T>(this T? source) where T : struct, INumber<T>

        /// <summary>
        /// 返回 <see cref="sbyte?"/> 的绝对值，如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 sbyte 值。</param>
        /// <returns>绝对值或 null。</returns>
        public static sbyte? AbsoluteValue(this sbyte? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="byte?"/> 的绝对值（以 short 表示），如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 byte 值。</param>
        /// <returns>绝对值（short 类型）或 null。</returns>
        public static short? AbsoluteValue(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="short?"/> 的绝对值，如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 short 值。</param>
        /// <returns>绝对值或 null。</returns>
        public static short? AbsoluteValue(this short? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="ushort?"/> 的绝对值（以 int 表示），如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 ushort 值。</param>
        /// <returns>绝对值（int 类型）或 null。</returns>
        public static int? AbsoluteValue(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="int?"/> 的绝对值，如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 int 值。</param>
        /// <returns>绝对值或 null。</returns>
        public static int? AbsoluteValue(this int? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="uint?"/> 的绝对值（以 long 表示），如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 uint 值。</param>
        /// <returns>绝对值（long 类型）或 null。</returns>
        public static long? AbsoluteValue(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="long?"/> 的绝对值，如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 long 值。</param>
        /// <returns>绝对值或 null。</returns>
        public static long? AbsoluteValue(this long? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="float?"/> 的绝对值，如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 float 值。</param>
        /// <returns>绝对值或 null。</returns>
        public static float? AbsoluteValue(this float? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="double?"/> 的绝对值，如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 double 值。</param>
        /// <returns>绝对值或 null。</returns>
        public static double? AbsoluteValue(this double? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        /// <summary>
        /// 返回 <see cref="decimal?"/> 的绝对值，如果为 null 则返回 null。
        /// </summary>
        /// <param name="this">可空 decimal 值。</param>
        /// <returns>绝对值或 null。</returns>
        public static decimal? AbsoluteValue(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }
    }
}
