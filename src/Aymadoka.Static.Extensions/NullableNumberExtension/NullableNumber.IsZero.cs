using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        public static bool IsZero(this sbyte? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this byte? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this short? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this ushort? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this int? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this uint? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this long? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this ulong? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this float? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this double? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        public static bool IsZero(this decimal? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }
    }
}
