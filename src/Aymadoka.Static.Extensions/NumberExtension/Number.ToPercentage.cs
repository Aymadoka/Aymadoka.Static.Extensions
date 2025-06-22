using System;
using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>
        /// 将 float 类型的数值转换为指定小数位数的百分比字符串，使用默认区域信息（zh-CN）。
        /// </summary>
        /// <param name="source">要转换的 float 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <returns>格式化后的百分比字符串。</returns>
        public static string ToPercentage(this float source, int places)
        {
            return ToPercentage(source, places, null);
        }

        /// <summary>
        /// 将 float 类型的数值转换为指定小数位数的百分比字符串，支持自定义区域信息。
        /// </summary>
        /// <param name="source">要转换的 float 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <param name="culture">区域信息，若为 null 则使用 zh-CN。</param>
        /// <returns>格式化后的百分比字符串。</returns>
        public static string ToPercentage(this float source, int places, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");

            var percentageValue = Math.Round(source * 100, places, MidpointRounding.AwayFromZero);
            var formattedValue = percentageValue.ToString($"F{places}", culture);

            return $"{formattedValue}%";
        }

        /// <summary>
        /// 将 double 类型的数值转换为指定小数位数的百分比字符串，使用默认区域信息（zh-CN）。
        /// </summary>
        /// <param name="source">要转换的 double 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <returns>格式化后的百分比字符串。</returns>
        public static string ToPercentage(this double source, int places)
        {
            return ToPercentage(source, places, null);
        }

        /// <summary>
        /// 将 double 类型的数值转换为指定小数位数的百分比字符串，支持自定义区域信息。
        /// </summary>
        /// <param name="source">要转换的 double 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <param name="culture">区域信息，若为 null 则使用 zh-CN。</param>
        /// <returns>格式化后的百分比字符串。</returns>
        public static string ToPercentage(this double source, int places, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");

            var percentageValue = Math.Round(source * 100, places, MidpointRounding.AwayFromZero);
            var formattedValue = percentageValue.ToString($"F{places}", culture);

            return $"{formattedValue}%";
        }

        /// <summary>
        /// 将 decimal 类型的数值转换为指定小数位数的百分比字符串，使用默认区域信息（zh-CN）。
        /// </summary>
        /// <param name="source">要转换的 decimal 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <returns>格式化后的百分比字符串。</returns>
        public static string ToPercentage(this decimal source, int places)
        {
            return ToPercentage(source, places, null);
        }

        /// <summary>
        /// 将 decimal 类型的数值转换为指定小数位数的百分比字符串，支持自定义区域信息。
        /// </summary>
        /// <param name="source">要转换的 decimal 数值。</param>
        /// <param name="places">小数位数。</param>
        /// <param name="culture">区域信息，若为 null 则使用 zh-CN。</param>
        /// <returns>格式化后的百分比字符串。</returns>
        public static string ToPercentage(this decimal source, int places, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");

            var percentageValue = Math.Round(source * 100, places, MidpointRounding.AwayFromZero);
            var formattedValue = percentageValue.ToString($"F{places}", culture);

            return $"{formattedValue}%";
        }
    }
}
