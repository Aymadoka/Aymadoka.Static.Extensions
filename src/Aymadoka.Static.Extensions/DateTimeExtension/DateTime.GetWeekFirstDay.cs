using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取当前日期所在周的第一天日期
        /// </summary>
        /// <param name="this">当前日期</param>
        /// <param name="weekStartsOn">指定一周的起始日（如周一或周日）</param>
        /// <returns>当前日期所在周的第一天（时间为 00:00:00）</returns>
        public static DateTime GetWeekFirstDay(this DateTime @this, DayOfWeek weekStartsOn)
        {
            int daysToSubtract = ((int)@this.DayOfWeek - (int)weekStartsOn + 7) % 7;
            var result = new DateTime(@this.Year, @this.Month, @this.Day, 0, 0, 0, @this.Kind).AddDays(-daysToSubtract);
            return result;
        }

        /// <summary>
        /// 获取当前日期所在周的第一天日期（以周一为一周的起始日 中国/ISO 标准）
        /// </summary>
        /// <param name="this">当前日期</param>
        /// <returns>当前日期所在周的第一天（时间为 00:00:00）</returns>
        public static DateTime GetWeekFirstDay(this DateTime @this)
        {
            var weekStartsOn = DayOfWeek.Monday;
            var result = @this.GetWeekFirstDay(weekStartsOn);
            return result;
        }
    }
}
