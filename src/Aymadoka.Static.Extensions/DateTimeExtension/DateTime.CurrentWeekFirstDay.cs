using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取当前日期所在周的第一天（周日）的日期，时间部分为 00:00:00
        /// </summary>
        /// <param name="this">要计算的日期</param>
        /// <returns>当前周第一天（周日）的日期，时间为 00:00:00，保留原有的 <see cref="DateTime.Kind"/></returns>
        public static DateTime CurrentWeekFirstDay(this DateTime @this)
        {
            var kind = @this.Kind;
            var result = new DateTime(@this.Year, @this.Month, @this.Day, 0, 0, 0, kind).AddDays(-(int)@this.DayOfWeek);
            return result;
        }
    }
}
