using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        /// <summary>
        /// 保留指定小数位数的 float? 类型值。
        /// </summary>
        /// <param name="this">要处理的可空 float 值。</param>
        /// <param name="keepPlaceCount">要保留的小数位数，默认为 2。</param>
        /// <returns>保留指定小数位数后的 float? 值，如果为 null 则返回 null。</returns>
        public static float? ToKeep(this float? @this, int keepPlaceCount = 2)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToKeep(keepPlaceCount);
            return result;
        }

        /// <summary>
        /// 保留指定小数位数的 double? 类型值。
        /// </summary>
        /// <param name="this">要处理的可空 double 值。</param>
        /// <param name="keepPlaceCount">要保留的小数位数，默认为 2。</param>
        /// <returns>保留指定小数位数后的 double? 值，如果为 null 则返回 null。</returns>
        public static double? ToKeep(this double? @this, int keepPlaceCount = 2)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ToKeep(keepPlaceCount);
            return result;
        }

        /// <summary>
        /// 保留指定小数位数的 decimal? 类型值。
        /// </summary>
        /// <param name="this">要处理的可空 decimal 值。</param>
        /// <param name="keepPlaceCount">要保留的小数位数，默认为 2。</param>
        /// <returns>保留指定小数位数后的 decimal? 值，如果为 null 则返回 null。</returns>
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
