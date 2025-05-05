using System;
using System.Globalization;
using System.Numerics;

namespace Aymadoka.Static.FloatingPointExtension
{
    public static partial class NumberExtensions
    {
        public static string ToPercentage<T>(this T source, int decimalPlaces = 2) where T : struct, IFloatingPoint<T>
        {
            return ToPercentage(source, decimalPlaces, null);
        }

        public static string ToPercentage<T>(this T source, int decimalPlaces, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>
        {
            culture ??= new CultureInfo("zh-CN");
            var percentageValue = T.Round(source * T.CreateChecked(100), decimalPlaces, MidpointRounding.AwayFromZero);
            var result = percentageValue.ToString($"F{decimalPlaces}", culture) + "%";
            return result;
        }
    }
}
