using System;
using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        public static string ToPercentage(this float source, int places)
        {
            return ToPercentage(source, places, null);
        }

        public static string ToPercentage(this float source, int places, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");

            var percentageValue = Math.Round(source * 100, places, MidpointRounding.AwayFromZero);
            var formattedValue = percentageValue.ToString($"F{places}", culture);

            return $"{formattedValue}%";
        }

        public static string ToPercentage(this double source, int places)
        {
            return ToPercentage(source, places, null);
        }

        public static string ToPercentage(this double source, int places, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");

            var percentageValue = Math.Round(source * 100, places, MidpointRounding.AwayFromZero);
            var formattedValue = percentageValue.ToString($"F{places}", culture);

            return $"{formattedValue}%";
        }

        public static string ToPercentage(this decimal source, int places)
        {
            return ToPercentage(source, places, null);
        }

        public static string ToPercentage(this decimal source, int places, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");

            var percentageValue = Math.Round(source * 100, places, MidpointRounding.AwayFromZero);
            var formattedValue = percentageValue.ToString($"F{places}", culture);

            return $"{formattedValue}%";
        }
    }
}
