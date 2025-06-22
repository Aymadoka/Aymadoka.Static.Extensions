using Aymadoka.Static.NumberExtension;
using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        /// <summary>
        /// 将可空 float 数值转换为科学计数法格式的字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 float? 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2。</param>
        /// <returns>转换后的科学计数法字符串；如果 source 为 null，则返回 null。</returns>
        public static string? ToScientificNotation(this float? source, int decimalPlaces = 2)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces);
            return result;
        }

        /// <summary>
        /// 将可空 float 数值转换为指定区域性和小数位数的科学计数法字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 float? 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数。</param>
        /// <param name="culture">用于格式化的区域性信息。</param>
        /// <returns>转换后的科学计数法字符串；如果 source 为 null，则返回 null。</returns>
        public static string? ToScientificNotation(this float? source, int decimalPlaces, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces, culture);
            return result;
        }

        /// <summary>
        /// 将可空 double 数值转换为科学计数法格式的字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 double? 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2。</param>
        /// <returns>转换后的科学计数法字符串；如果 source 为 null，则返回 null。</returns>
        public static string? ToScientificNotation(this double? source, int decimalPlaces = 2)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces);
            return result;
        }

        /// <summary>
        /// 将可空 double 数值转换为指定区域性和小数位数的科学计数法字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 double? 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数。</param>
        /// <param name="culture">用于格式化的区域性信息。</param>
        /// <returns>转换后的科学计数法字符串；如果 source 为 null，则返回 null。</returns>
        public static string? ToScientificNotation(this double? source, int decimalPlaces, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces, culture);
            return result;
        }

        /// <summary>
        /// 将可空 decimal 数值转换为科学计数法格式的字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 decimal? 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2。</param>
        /// <returns>转换后的科学计数法字符串；如果 source 为 null，则返回 null。</returns>
        public static string? ToScientificNotation(this decimal? source, int decimalPlaces = 2)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces);
            return result;
        }

        /// <summary>
        /// 将可空 decimal 数值转换为指定区域性和小数位数的科学计数法字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 decimal? 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数。</param>
        /// <param name="culture">用于格式化的区域性信息。</param>
        /// <returns>转换后的科学计数法字符串；如果 source 为 null，则返回 null。</returns>
        public static string? ToScientificNotation(this decimal? source, int decimalPlaces, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces, culture);
            return result;
        }
    }
}
