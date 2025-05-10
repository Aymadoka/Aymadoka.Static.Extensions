using Aymadoka.Static.NumberExtension;
using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        /// <summary>将小数值转换为科学计数法格式的字符串</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
        /// <returns>转换后的科学计数法字符串</returns>
        public static string? ToScientificNotation(this float? source, int decimalPlaces = 2)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces);
            return result;
        }

        public static string? ToScientificNotation(this float? source, int decimalPlaces, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces, culture);
            return result;
        }

        public static string? ToScientificNotation(this double? source, int decimalPlaces = 2)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces);
            return result;
        }

        public static string? ToScientificNotation(this double? source, int decimalPlaces, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces, culture);
            return result;
        }

        public static string? ToScientificNotation(this decimal? source, int decimalPlaces = 2)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToScientificNotation(decimalPlaces);
            return result;
        }

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
