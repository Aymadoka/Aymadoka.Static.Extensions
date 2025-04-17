using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.NumberExtension
{
    public static class NumberExtensions
    {
        public static bool IsInteger<T>(this T source) where T : INumber<T>
        {
            return source % T.One == T.Zero;
        }

        public static string ToPercentage<T>(this T source, int decimalPlaces = 2) where T : INumber<T>
        {
            var a = T.CreateSaturating(100);

            // 计算百分比值并格式化为指定小数位数的字符串
            var percentageValue = Math.Round(source * a, decimalPlaces, MidpointRounding.AwayFromZero);
            var result = percentageValue.ToString($"F{decimalPlaces}") + "%";
            return result;
        }
    }
}
