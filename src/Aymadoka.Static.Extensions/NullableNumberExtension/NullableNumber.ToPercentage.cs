using System.Globalization;
using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        /// <summary>
        /// 将可空 <see cref="float"/> 数值转换为指定小数位数的百分比字符串。
        /// </summary>
        /// <param name="source">要转换的可空 <see cref="float"/> 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <returns>格式化后的百分比字符串，若 <paramref name="source"/> 为 null 则返回 null。</returns>
        public static string? ToPercentage(this float? source, int places)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToPercentage(places);
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="float"/> 数值转换为指定小数位数和区域性的百分比字符串。
        /// </summary>
        /// <param name="source">要转换的可空 <see cref="float"/> 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <param name="culture">区域性信息。</param>
        /// <returns>格式化后的百分比字符串，若 <paramref name="source"/> 为 null 则返回 null。</returns>
        public static string? ToPercentage(this float? source, int places, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToPercentage(places, culture);
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="double"/> 数值转换为指定小数位数的百分比字符串。
        /// </summary>
        /// <param name="source">要转换的可空 <see cref="double"/> 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <returns>格式化后的百分比字符串，若 <paramref name="source"/> 为 null 则返回 null。</returns>
        public static string? ToPercentage(this double? source, int places)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToPercentage(places);
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="double"/> 数值转换为指定小数位数和区域性的百分比字符串。
        /// </summary>
        /// <param name="source">要转换的可空 <see cref="double"/> 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <param name="culture">区域性信息。</param>
        /// <returns>格式化后的百分比字符串，若 <paramref name="source"/> 为 null 则返回 null。</returns>
        public static string? ToPercentage(this double? source, int places, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToPercentage(places, culture);
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="decimal"/> 数值转换为指定小数位数的百分比字符串。
        /// </summary>
        /// <param name="source">要转换的可空 <see cref="decimal"/> 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <returns>格式化后的百分比字符串，若 <paramref name="source"/> 为 null 则返回 null。</returns>
        public static string? ToPercentage(this decimal? source, int places)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToPercentage(places);
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="decimal"/> 数值转换为指定小数位数和区域性的百分比字符串。
        /// </summary>
        /// <param name="source">要转换的可空 <see cref="decimal"/> 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <param name="culture">区域性信息。</param>
        /// <returns>格式化后的百分比字符串，若 <paramref name="source"/> 为 null 则返回 null。</returns>
        public static string? ToPercentage(this decimal? source, int places, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToPercentage(places, culture);
            return result;
        }
    }
}
