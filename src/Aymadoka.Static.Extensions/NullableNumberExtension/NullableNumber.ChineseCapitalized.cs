using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static string? ChineseCapitalized<T>(this T? source) where T : struct, IFloatingPoint<T>

        public static string? ChineseCapitalized(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this short? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this int? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this long? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this ulong? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this float? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this double? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        public static string? ChineseCapitalized(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }
    }
}
