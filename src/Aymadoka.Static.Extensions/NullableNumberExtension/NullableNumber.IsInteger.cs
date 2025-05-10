using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static bool IsInteger<T>(this T? source) where T : struct, INumber<T>

        public static bool IsInteger(this sbyte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this short? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this int? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this long? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this ulong? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this float? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this double? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }

        public static bool IsInteger(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return false;
            }

            return @this.Value.IsInteger();
        }
    }
}
