using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static T? AbsoluteValue<T>(this T? source) where T : struct, INumber<T>

        public static sbyte? AbsoluteValue(this sbyte? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static short? AbsoluteValue(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static short? AbsoluteValue(this short? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static int? AbsoluteValue(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static int? AbsoluteValue(this int? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static long? AbsoluteValue(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static long? AbsoluteValue(this long? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static float? AbsoluteValue(this float? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static double? AbsoluteValue(this double? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }

        public static decimal? AbsoluteValue(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return @this;
            }

            var result = @this.Value.AbsoluteValue();
            return result;
        }
    }
}
