using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 移除 <see cref="DateTimeOffset"/> 的时间部分，仅保留日期部分。
        /// </summary>
        /// <param name="sourceDateTime">要移除时间部分的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>仅包含日期部分的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        ///     <list type="bullet">
        ///         <item>返回的 <see cref="DateTimeOffset"/> 的时间部分将被设置为 00:00:00。</item>
        ///         <item>保留原始的时区偏移量。/item> 
        ///     </list>
        /// </remarks>
        public static DateTimeOffset RemoveTime(this DateTimeOffset sourceDateTime)
        {
            var timeOfDay = sourceDateTime.TimeOfDay;
            var result = sourceDateTime - timeOfDay;
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 的前一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取前一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>前一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// - 如果输入日期为某月的第一天，返回的日期将是上个月的最后一天。
        /// </remarks>
        public static DateTimeOffset PreviousDay(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.AddDays(-1);
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 的下一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取下一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>下一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset NextDay(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.AddDays(1);
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在月份的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份第一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>所在月份第一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset CurrentMonthFirstDay(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.AddDays(1 - sourceDateTime.Day);
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在日期的上一个月的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取上一个月第一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>上一个月第一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset GetFirstDayOfLastMonth(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.CurrentMonthFirstDay().AddMonths(-1);
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在日期的下一个月的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取下一个月第一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>下一个月第一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset GetFirstDayOfNextMonth(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.CurrentMonthFirstDay().AddMonths(1);
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在月份的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份第一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>所在月份第一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset GetFirstDayOfMonth(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.CurrentMonthFirstDay();
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在月份的最后一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份最后一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>所在月份最后一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset GetLastDayOfMonth(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.CurrentMonthFirstDay().AddMonths(1).AddDays(-1);
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在月份的倒数第二天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取倒数第二天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>所在月份倒数第二天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset GetSecondDayToLastOfMonth(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.CurrentMonthFirstDay().AddMonths(1).AddDays(-2);
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在月份的最后一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份最后一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>所在月份最后一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset CurrentMonthLastDay(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.CurrentMonthFirstDay().AddMonths(1).AddDays(-1);
            return result;
        }

        /// <summary>
        /// 判断 <see cref="DateTimeOffset"/> 是否为周末。
        /// </summary>
        /// <param name="sourceDateTime">要判断的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>如果是周六或周日，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsWeekend(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.DayOfWeek == DayOfWeek.Saturday || sourceDateTime.DayOfWeek == DayOfWeek.Sunday;
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 的秒级时间戳。
        /// </summary>
        /// <param name="sourceDateTime">要获取时间戳的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>秒级时间戳。</returns>
        public static long GetSecondLevelTimeStamp(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.ToUnixTimeSeconds();
            return result;
        }

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 的毫秒级时间戳。
        /// </summary>
        /// <param name="sourceDateTime">要获取时间戳的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>毫秒级时间戳。</returns>
        public static long GetMillisecondLevelTimeStamp(this DateTimeOffset sourceDateTime)
        {
            var result = sourceDateTime.ToUnixTimeMilliseconds();
            return result;
        }

        /// <summary>
        /// 判断 <see cref="DateTimeOffset"/> 是否在指定的时间范围内。
        /// </summary>
        /// <param name="dateTimeOffset">要检查的 <see cref="DateTimeOffset"/>。</param>
        /// <param name="start">范围的开始时间。</param>
        /// <param name="end">范围的结束时间。</param>
        /// <returns>如果在范围内，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsBetween(this DateTimeOffset dateTimeOffset, DateTimeOffset start, DateTimeOffset end)
        {
            return dateTimeOffset >= start && dateTimeOffset <= end;
        }
    }
}
