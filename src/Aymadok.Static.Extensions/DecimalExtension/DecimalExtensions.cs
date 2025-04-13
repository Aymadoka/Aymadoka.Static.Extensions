using System;
using System.Text.RegularExpressions;

namespace Aymadok.Static.DecimalExtension
{
    public static class DecimalExtensions
    {
        /// <summary>使用四舍五入的方式保留两位小数</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <returns>保留两位小数后的结果</returns>
        public static decimal Keep(this decimal source)
        {
            var result = source.Keep(2);
            return result;
        }

        /// <summary>使用四舍五入的方式保留指定的小数位</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <param name="keepPlaceCount">需要保留的小数位数</param>
        /// <returns>保留指定小数位后的结果</returns>
        public static decimal Keep(this decimal source, int keepPlaceCount)
        {
            var result = Math.Round(source, keepPlaceCount, MidpointRounding.AwayFromZero);
            return result;
        }

        /// <summary>判断小数值是否为整数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是整数返回 true，否则返回 false</returns>
        public static bool IsInteger(this decimal source)
        {
            return (source % 1) == 0;
        }

        /// <summary>将小数值转换为百分比格式的字符串</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
        /// <returns>转换后的百分比字符串</returns>
        public static string ToPercentage(this decimal source, int decimalPlaces = 2)
        {
            // 计算百分比值并格式化为指定小数位数的字符串
            var percentageValue = Math.Round(source * 100, decimalPlaces, MidpointRounding.AwayFromZero);
            var result = percentageValue.ToString($"F{decimalPlaces}") + "%";
            return result;
        }

        /// <summary>获取小数值的绝对值</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <returns>小数值的绝对值</returns>
        public static decimal AbsoluteValue(this decimal source)
        {
            var result = Math.Abs(source);
            return result;
        }

        /// <summary>将小数值格式化为货币字符串</summary>
        /// <param name="source">需要格式化的原始小数值</param>
        /// <param name="culture">指定的区域文化，默认为 "zh-CN"</param>
        /// <returns>格式化后的货币字符串</returns>
        public static string ToCurrency(this decimal source, string culture = "zh-CN")
        {
            source = source.Keep(2);
            var cultureInfo = new System.Globalization.CultureInfo(culture);
            var result = source.ToString("C", cultureInfo);
            return result;
        }

        /// <summary>将小数值限制在指定的最小值和最大值之间</summary>
        /// <param name="source">需要限制的原始小数值</param>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns>限制范围后的结果</returns>
        public static decimal Clamp(this decimal source, decimal min, decimal max)
        {
            if (source < min)
            {
                return min;
            }
            else if (source > max)
            {
                return max;
            }

            return source;
        }

        /// <summary>判断小数值是否在指定范围内</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <param name="min">范围的最小值</param>
        /// <param name="max">范围的最大值</param>
        /// <returns>如果在范围内返回 true，否则返回 false</returns>
        public static bool IsInRange(this decimal source, decimal min, decimal max)
        {
            var result = source >= min && source <= max;
            return result;
        }

        /// <summary>移除小数部分，仅保留整数部分</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <returns>移除小数部分后的整数值</returns>
        public static decimal Truncate(this decimal source)
        {
            var result = Math.Truncate(source);
            return result;
        }

        /// <summary>将小数值转换为科学计数法格式的字符串</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
        /// <returns>转换后的科学计数法字符串</returns>
        public static string ToScientificNotation(this decimal source, int decimalPlaces = 2)
        {
            return source.ToString($"E{decimalPlaces}");
        }

        /// <summary>判断小数值是否为正数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是正数返回 true，否则返回 false</returns>
        public static bool IsPositive(this decimal source)
        {
            return source > 0;
        }

        /// <summary>判断小数值是否为负数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是负数返回 true，否则返回 false</returns>
        public static bool IsNegative(this decimal source)
        {
            return source < 0;
        }

        /// <summary>判断小数值是否为零</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是零返回 true，否则返回 false</returns>
        public static bool IsZero(this decimal source)
        {
            return source == 0;
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
        public static string ChineseCapitalized(this decimal source)
        {
            if (source == 0)
            {
                return "零元";
            }

            source = source.Keep();

            var STRING = "#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A";
            var str = source.ToString(STRING);

            var s = Regex.Replace(str, @"(((?<=-)|(?!-)^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");
            var result = Regex.Replace(s, ".", c => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[c.Value[0] - '-'].ToString());

            if (source % 1 == 0)
            {
                result += "整";
            }

            return result;
        }
    }
}
