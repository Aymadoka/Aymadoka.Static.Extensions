using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取当前日期所在周的最后一天（周日）的日期，时间部分为00:00:00
        /// </summary>
        /// <param name="this">要计算的日期</param>
        /// <returns>当前周最后一天（周日）的日期，时间为00:00:00，保留原始 DateTimeKind</returns>
        public static DateTime CurrentWeekLastDay(this DateTime @this)
        {
            var kind = @this.Kind;
            var result = new DateTime(@this.Year, @this.Month, @this.Day, 0, 0, 0, kind).AddDays(6 - (int)@this.DayOfWeek);
            return result;
        }
    }
}
