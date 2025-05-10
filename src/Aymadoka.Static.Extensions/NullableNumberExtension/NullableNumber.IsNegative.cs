using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        //  static bool IsNegative<T>(this T? source) where T : struct, INumber<T>

        public static bool IsNegative(this sbyte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this short? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this int? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this long? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this ulong? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this float? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this double? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }

        public static bool IsNegative(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            var result = @this.Value.IsNegative();
            return result;
        }
    }
}
