using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>获取指定日期的上一个月的第一天</summary>
        /// <param name="this">源日期</param>
        /// <returns>源日期的上一个月的第一天，保留时间部分</returns>
        public static DateTime GetLastMonthFirstDay(this DateTime @this)
        {
            var result = @this.CurrentMonthFirstDay().AddMonths(-1);
            return result;
        }
    }
}
