using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        public static string? ToPercentage(this float? source, int places)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.ToPercentage(places);
            return result;
        }

        public static string? ToPercentage(this float? source, int places, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.ToPercentage(places, culture);
            return result;
        }

        public static string? ToPercentage(this double? source, int places)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.ToPercentage(places);
            return result;
        }

        public static string? ToPercentage(this double? source, int places, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.ToPercentage(places, culture);
            return result;
        }

        public static string? ToPercentage(this decimal? source, int places)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.ToPercentage(places);
            return result;
        }

        public static string? ToPercentage(this decimal? source, int places, CultureInfo? culture)
        {
            if (!source.HasValue)
            {
                return null;
            }

            var result = source.ToPercentage(places, culture);
            return result;
        }
    }
}
