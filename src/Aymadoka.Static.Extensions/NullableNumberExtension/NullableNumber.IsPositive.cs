using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static bool IsPositive<T>(this T? source) where T : struct, INumber<T>

        public static bool IsPositive(this sbyte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this short? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this int? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this long? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this ulong? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this float? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this double? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }

        public static bool IsPositive(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsPositive();
            return result;
        }
    }
}
