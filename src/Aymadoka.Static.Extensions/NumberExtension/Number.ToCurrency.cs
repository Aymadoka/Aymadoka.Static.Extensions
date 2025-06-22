using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static string ToCurrency<T>(this T source, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>

        /// <summary>
        /// 将 <see cref="sbyte"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this sbyte @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="byte"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this byte @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="short"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this short @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="ushort"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this ushort @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="int"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this int @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="uint"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this uint @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="long"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this long @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="ulong"/> 值格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this ulong @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="float"/> 值保留两位小数后格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this float @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToKeep(2).ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="double"/> 值保留两位小数后格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this double @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToKeep(2).ToString("C", culture);
            return result;
        }

        /// <summary>
        /// 将 <see cref="decimal"/> 值保留两位小数后格式化为货币字符串。
        /// </summary>
        /// <param name="this">要格式化的值。</param>
        /// <param name="culture">可选，指定区域信息，默认为 "zh-CN"。</param>
        /// <returns>货币格式的字符串。</returns>
        public static string ToCurrency(this decimal @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToKeep(2).ToString("C", culture);
            return result;
        }
    }
}
