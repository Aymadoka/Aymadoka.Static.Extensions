using System.Globalization;
using System.Text.RegularExpressions;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static T AbsoluteValue<T>(this T source) where T : struct, INumber<T>

        private const string STRING = "#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A";
        private const string REPLACE = @"(((?<=-)|(?!-)^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))";
        private const string MATCH = "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰";

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

        public static string ChineseCapitalized(this byte @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this short @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this ushort @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this int @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this uint @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this long @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this ulong @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this float @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this double @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }

        public static string ChineseCapitalized(this decimal @this)
        {
            if (@this.IsZero())
            {
                return "零元";
            }

            var culture = new CultureInfo("zh-CN");
            var str = @this.ToString(STRING, culture);

            var s = Regex.Replace(str, REPLACE, "${b}${z}");
            var result = Regex.Replace(s, ".", c => MATCH[c.Value[0] - '-'].ToString());

            if (@this.IsInteger())
            {
                result += "整";
            }

            return result;
        }
    }
}
