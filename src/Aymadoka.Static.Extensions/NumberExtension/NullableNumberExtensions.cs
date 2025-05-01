using System.Globalization;
using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static class NullableNumberExtensions 
    {
        public static bool IsInteger<T>(this T? source) where T : struct, INumber<T>
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsInteger();
        }

        /// <summary>判断小数值是否为正数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是正数返回 true，否则返回 false</returns>
        public static bool IsPositive<T>(this T? source) where T : struct, INumber<T>
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsPositive();
        }

        /// <summary>判断小数值是否为负数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是负数返回 true，否则返回 false</returns>
        public static bool IsNegative<T>(this T? source) where T : struct, INumber<T>
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsNegative();
        }

        /// <summary>判断小数值是否为零</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是零返回 true，否则返回 false</returns>
        public static bool IsZero<T>(this T? source) where T : struct, INumber<T>
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>获取小数值的绝对值</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <returns>小数值的绝对值</returns>
        public static T? AbsoluteValue<T>(this T? source) where T : struct, INumber<T>
        {
            if (!source.HasValue)
            {
                return source;
            }

            return source.Value.AbsoluteValue();
        }

        public static T? Keep<T>(this T? source, int keepPlaceCount = 2) where T : struct, IFloatingPoint<T>
        {
            if (!source.HasValue)
            {
                return null;
            }

            T value = source.Value.Keep(keepPlaceCount);
            return value;
        }

        public static string? ToPercentage<T>(this T? source, int decimalPlaces = 2) where T : struct, IFloatingPoint<T>
        {
            return source.ToPercentage(decimalPlaces, null);
        }

        public static string? ToPercentage<T>(this T? source, int decimalPlaces, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToPercentage(decimalPlaces, culture);
            return result;
        }

        /// <summary>将小数值格式化为货币字符串</summary>
        /// <param name="source">需要格式化的原始小数值</param>
        /// <param name="culture">指定的区域文化，默认为 "zh-CN"</param>
        /// <returns>格式化后的货币字符串</returns>
        public static string? ToCurrency<T>(this T? source, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.Value.ToCurrency();
            return result;
        }

        /// <summary>将小数值转换为科学计数法格式的字符串</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
        /// <returns>转换后的科学计数法字符串</returns>
        public static string? ToScientificNotation<T>(this T? source, int decimalPlaces = 2) where T : struct, IFloatingPoint<T>
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        public static string? ToScientificNotation<T>(this T? source, int decimalPlaces, CultureInfo? culture) where T : struct, IFloatingPoint<T>
        {
            if (!source.HasValue)
            {
                return null;
            }

            return source.Value.ToScientificNotation(decimalPlaces, culture);
        }

        public static string? ChineseCapitalized<T>(this T? source) where T : struct, IFloatingPoint<T>
        {
            if (!source.HasValue)
            {
                return null;
            }

            if (source == T.Zero)
            {
                return "零元";
            }

            return source.Value.Keep().ChineseCapitalized();
        }
    }
}
