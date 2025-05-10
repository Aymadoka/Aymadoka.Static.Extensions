using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        public static float? ToKeep(this float? @this, int keepPlaceCount = 2)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToKeep(keepPlaceCount);
            return result;
        }

        public static double? ToKeep(this double? @this, int keepPlaceCount = 2)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToKeep(keepPlaceCount);
            return result;
        }

        public static decimal? ToKeep(this decimal? @this, int keepPlaceCount = 2)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToKeep(keepPlaceCount);
            return result;
        }
    }
}
