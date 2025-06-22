using Aymadoka.Static.NumberExtension;
using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static string? ToCurrency<T>(this T? source, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>

        /// <summary>
        /// 将 <see cref="sbyte?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="sbyte"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this sbyte? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="byte?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="byte"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this byte? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="short?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="short"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this short? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="ushort?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="ushort"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this ushort? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="int?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="int"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this int? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="uint?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="uint"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this uint? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="long?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="long"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this long? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="ulong?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="ulong"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this ulong? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="float?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="float"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this float? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="double?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="double"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this double? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="decimal?"/> 类型的值格式化为货币字符串。
        /// </summary>
        /// <param name="this">可空的 <see cref="decimal"/> 值。</param>
        /// <param name="culture">可选，指定区域信息。</param>
        /// <returns>格式化后的货币字符串，若值为 null 则返回 null。</returns>
        public static string? ToCurrency(this decimal? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }
    }
}
