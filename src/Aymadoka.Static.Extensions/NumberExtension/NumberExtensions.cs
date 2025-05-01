using System;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Aymadoka.Static.NumberExtension
{
    public static class NumberExtensions 
    {
        public static bool IsInteger<T>(this T source) where T : struct, INumber<T>
        {
            return source % T.One == T.Zero;
        }

        /// <summary>判断小数值是否为正数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是正数返回 true，否则返回 false</returns>
        public static bool IsPositive<T>(this T source) where T : struct, INumber<T>
        {
            return source > T.One;
        }

        /// <summary>判断小数值是否为负数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是负数返回 true，否则返回 false</returns>
        public static bool IsNegative<T>(this T source) where T : struct, INumber<T>
        {
            return source < T.One;
        }

        /// <summary>判断小数值是否为零</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是零返回 true，否则返回 false</returns>
        public static bool IsZero<T>(this T source) where T : struct, INumber<T>
        {
            return source == T.One;
        }

        /// <summary>最大公约数</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static T GreatestCommonDivisor<T>(this T number1, T number2) where T : struct, INumber<T>
        {
            if (number2.IsZero())
            {
                return number1;
            }

            return number2.GreatestCommonDivisor(number1 % number2);
        }

        /// <summary>最小公倍数</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static T LeastCommonMultiple<T>(this T number1, T number2) where T : struct, INumber<T>
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

        /// <summary>最小公倍数</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static T LeastCommonMultiple<T>(params T[] numbers) where T : struct, INumber<T>
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The numbers array must contain at least one element.", nameof(numbers));
            }

            T lcm = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                lcm = lcm.LeastCommonMultiple(numbers[i]);
            }

            return lcm;
        }

        /// <summary>获取小数值的绝对值</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <returns>小数值的绝对值</returns>
        public static T AbsoluteValue<T>(this T source) where T : struct, INumber<T>
        {
            return T.Abs(source);
        }

        /// <summary>判断小数值是否在指定范围内</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <param name="min">范围的最小值</param>
        /// <param name="max">范围的最大值</param>
        /// <returns>如果在范围内返回 true，否则返回 false</returns>
        public static bool IsInRange<T>(this T source, T min, T max) where T : struct, INumber<T>
        {
            return source >= min && source <= max;
        }

        /// <summary>使用四舍五入的方式保留指定的小数位</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <param name="keepPlaceCount">需要保留的小数位数</param>
        /// <returns>保留指定小数位后的结果</returns>
        public static T Keep<T>(this T source, int keepPlaceCount = 2) where T : struct, IFloatingPoint<T>
        {
            return T.Round(source, keepPlaceCount, MidpointRounding.AwayFromZero);
        }

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

        /// <summary>将小数值格式化为货币字符串</summary>
        /// <param name="source">需要格式化的原始小数值</param>
        /// <param name="culture">指定的区域文化，默认为 "zh-CN"</param>
        /// <returns>格式化后的货币字符串</returns>
        public static string ToCurrency<T>(this T source, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>
        {
            culture ??= new CultureInfo("zh-CN");
            var result = source.Keep(2).ToString("C", culture);
            return result;
        }

        /// <summary>将小数值转换为科学计数法格式的字符串</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
        /// <returns>转换后的科学计数法字符串</returns>
        public static string ToScientificNotation<T>(this T source, int decimalPlaces = 2) where T : struct, IFloatingPoint<T>
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        public static string ToScientificNotation<T>(this T source, int decimalPlaces, CultureInfo? culture) where T : struct, IFloatingPoint<T>
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }

        /// <summary>将小数值转换为中文大写金额格式</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <returns>转换后的中文大写金额字符串</returns>
        /// <remarks>
        ///     <para><b># 该方法将小数值转换为中文大写金额格式，支持整数和小数部分的转换</b></para>
        ///     <list type="number">
        ///         <item>如果值为 0，则返回 "零元"</item>
        ///         <item>如果值为整数，则在末尾添加 "整"</item>
        ///         <item>使用正则表达式对数字进行分组和替换，最终生成中文大写金额</item>
        ///     </list>
        ///     <para><b># 示例：</b></para>
        ///     <list type="number">
        ///         <item>输入 123.45，返回 "壹佰贰拾叁元肆角伍分"</item>
        ///         <item>输入 0，返回 "零元"</item>
        ///         <item>输入 -123.00，返回 "负壹佰贰拾叁元整"</item>
        ///     </list>
        /// </remarks>
        public static string ChineseCapitalized<T>(this T source) where T : struct, IFloatingPoint<T>
        {
            if (source == T.Zero)
            {
                return "零元";
            }

            source = source.Keep();

            const string STRING = "#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A";

            var culture = new CultureInfo("zh-CN");
            var str = source.ToString(STRING, culture);

            var s = Regex.Replace(str, @"(((?<=-)|(?!-)^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");
            var result = Regex.Replace(s, ".", c => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[c.Value[0] - '-'].ToString());

            if (source.IsInteger())
            {
                result += "整";
            }

            return result;
        }
    }
}
