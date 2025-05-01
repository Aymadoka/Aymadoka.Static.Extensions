using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static class DateTimeExtensions
    {
        /// <summary>去除指定日期的时间部分，仅保留日期部分（时间部分为 00:00:00）</summary>
        /// <param name="this">源日期</param>
        /// <returns>仅包含日期部分的 <see cref="DateTime"/> 对象</returns>
        public static DateTime RemoveTime(this DateTime @this)
        {
            return @this.Date;
        }

        /// <summary>获取指定日期的前一天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期的前一天，保留时间部分</returns>
        public static DateTime PreviousDay(this DateTime @this)
        {
            var result = @this.AddDays(-1);
            return result;
        }

        /// <summary>获取指定日期的下一天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期的下一天，保留时间部分</returns>
        public static DateTime NextDay(this DateTime @this)
        {
            var result = @this.AddDays(1);
            return result;
        }

        /// <summary>获取指定日期所在月份的第一天</summary>
        /// <param name="dt">源日期</param>
        /// <returns>源日期所在月份的第一天，保留时间部分</returns>
        public static DateTime CurrentMonthFirstDay(this DateTime @this)
        {
            var result = @this.AddDays(1 - @this.Day);
            return result;
        }

        /// <summary>获取指定日期的上一个月的第一天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期的上一个月的第一天，保留时间部分</returns>
        public static DateTime GetFirstDayOfLastMonth(this DateTime @this)
        {
            var result = @this.CurrentMonthFirstDay().AddMonths(-1);
            return result;
        }

        /// <summary>获取指定日期的下一个月的第一天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期的下一个月的第一天，保留时间部分</returns>
        public static DateTime GetFirstDayOfNextMonth(this DateTime @this)
        {
            var result = @this.CurrentMonthFirstDay().AddMonths(1);
            return result;
        }

        /// <summary>获取指定日期所在月份的第一天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期所在月份的第一天，保留时间部分</returns>
        public static DateTime GetFirstDayOfMonth(this DateTime @this)
        {
            var result = @this.CurrentMonthFirstDay();
            return result;
        }

        /// <summary>获取指定日期所在月份的最后一天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期所在月份的最后一天，保留时间部分</returns>
        public static DateTime GetLastDayOfMonth(this DateTime @this)
        {
            var result = @this.CurrentMonthFirstDay().AddMonths(1).AddDays(-1);
            return result;
        }

        /// <summary>获取指定日期所在月份的倒数第二天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期所在月份的倒数第二天，保留时间部分</returns>
        public static DateTime GetSecondDayToLastOfMonth(this DateTime @this)
        {
            var result = @this.CurrentMonthFirstDay().AddMonths(1).AddDays(-2);
            return result;
        }

        /// <summary>判断指定日期是否为周末（星期六或星期日）</summary>
        /// <param name="this">源日期</param>
        /// <returns>如果是周末，则返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool IsWeekend(this DateTime @this)
        {
            var result = @this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday;
            return result;
        }
    }
}
