namespace Aymadoka.Static.DecimalExtension
{
    public static class NullableDecimalExtensions
    {
        public static decimal? Keep(this decimal? source)
        {
            return source.Keep(2);
        }

        public static decimal? Keep(this decimal? source, int keepPlaceCount)
        {
            if (source.HasValue)
            {
                return source.Value.Keep(keepPlaceCount);
            }
            else
            {
                return null;
            }
        }

        public static bool IsInteger(this decimal? source)
        {
            if (source.HasValue)
            {
                return source.Value.IsInteger();
            }

            return false;
        }

        public static string? ToPercentage(this decimal? source, int decimalPlaces = 2)
        {
            if (source.HasValue)
            {
                return source.Value.ToPercentage(decimalPlaces);
            }

            return null;
        }

        public static decimal? AbsoluteValue(this decimal? source)
        {
            if (source.HasValue)
            {
                return source.Value.AbsoluteValue();
            }

            return null;
        }

        public static string? ToCurrency(this decimal? source, string culture = "zh-CN")
        {
            if (source.HasValue)
            {
                return source.Value.ToCurrency(culture);
            }

            return null;
        }

        public static decimal? Clamp(this decimal? source, decimal min, decimal max)
        {
            if (source.HasValue)
            {
                return source.Value.Clamp(min, max);
            }

            return null;
        }

        public static bool IsInRange(this decimal? source, decimal min, decimal max)
        {
            if (source.HasValue)
            {
                return source.Value.IsInRange(min, max);
            }

            return false;
        }

        public static decimal? Truncate(this decimal? source)
        {
            if (source.HasValue)
            {
                return source.Value.Truncate();
            }

            return null;
        }

        public static string? ToScientificNotation(this decimal? source, int decimalPlaces = 2)
        {
            if (source.HasValue)
            {
                return source.Value.ToScientificNotation();
            }

            return null;
        }

        public static bool IsPositive(this decimal? source)
        {
            if (source.HasValue)
            {
                return source.Value.IsPositive();
            }

            return false;
        }

        public static bool IsNegative(this decimal? source)
        {
            if (source.HasValue)
            {
                return source.Value.IsNegative();
            }

            return false;
        }

        public static bool IsZero(this decimal? source)
        {
            if (source.HasValue)
            {
                return source.Value.IsZero();
            }

            return false;
        }

        public static string? ChineseCapitalized(this decimal? source)
        {
            if (source.HasValue)
            {
                return source.Value.ChineseCapitalized();
            }

            return null;
        }
    }
}
