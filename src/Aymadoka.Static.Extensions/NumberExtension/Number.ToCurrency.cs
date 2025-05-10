using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static string ToCurrency<T>(this T source, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>

        public static string ToCurrency(this sbyte @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this byte @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this short @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this ushort @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this int @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this uint @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this long @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this ulong @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this float @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToKeep(2).ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this double @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToKeep(2).ToString("C", culture);
            return result;
        }

        public static string ToCurrency(this decimal @this, CultureInfo? culture = null)
        {
            culture ??= new CultureInfo("zh-CN");
            var result = @this.ToKeep(2).ToString("C", culture);
            return result;
        }
    }
}
