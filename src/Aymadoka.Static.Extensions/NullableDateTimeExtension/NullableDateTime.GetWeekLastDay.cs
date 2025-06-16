using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 获取指定日期所在周的最后一天（根据指定的周起始日）。
        /// </summary>
        /// <param name="this">可空的日期。</param>
        /// <param name="weekStartsOn">一周的起始日。</param>
        /// <returns>该日期所在周的最后一天，若日期为 null 则返回 null。</returns>
        public static DateTime? GetWeekLastDay(this DateTime? @this, DayOfWeek weekStartsOn)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetWeekLastDay(weekStartsOn);
            return result;
        }

        /// <summary>
        /// 获取指定日期所在周的最后一天（以周一为一周的起始日）。
        /// </summary>
        /// <param name="this">可空的日期。</param>
        /// <returns>该日期所在周的最后一天，若日期为 null 则返回 null。</returns>
        public static DateTime? GetWeekLastDay(this DateTime? @this)
        {
            var weekStartsOn = DayOfWeek.Monday;
            var result = @this.GetWeekLastDay(weekStartsOn);
            return result;
        }
    }
}
