using Aymadoka.Static.NumberExtension;
using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static string? ToCurrency<T>(this T? source, CultureInfo? culture = null) where T : struct, IFloatingPoint<T>

        public static string? ToCurrency(this sbyte? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this byte? @this, CultureInfo? culture = null)
        {
             if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this short? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this ushort? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this int? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this uint? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this long? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this ulong? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this float? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this double? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }

        public static string? ToCurrency(this decimal? @this, CultureInfo? culture = null)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToCurrency(culture);
            return result;
        }
    }
}
