using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 获取指定日期所在周的第一天（根据指定的周起始日）。
        /// </summary>
        /// <param name="this">可空的日期。</param>
        /// <param name="weekStartsOn">周的起始日。</param>
        /// <returns>该日期所在周的第一天，如果日期为 null 则返回 null。</returns>
        public static DateTime? GetWeekFirstDay(this DateTime? @this, DayOfWeek weekStartsOn)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetWeekFirstDay(weekStartsOn);
            return result;
        }

        /// <summary>
        /// 获取指定日期所在周的第一天（默认以周一为起始日）。
        /// </summary>
        /// <param name="this">可空的日期。</param>
        /// <returns>该日期所在周的第一天，如果日期为 null 则返回 null。</returns>
        public static DateTime? GetWeekFirstDay(this DateTime? @this)
        {
            var weekStartsOn = DayOfWeek.Monday;
            var result = @this.GetWeekFirstDay(weekStartsOn);
            return result;
        }
    }
}
