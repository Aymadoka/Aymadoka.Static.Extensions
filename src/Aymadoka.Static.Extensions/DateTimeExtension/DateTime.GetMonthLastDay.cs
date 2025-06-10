using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取当前日期所在月份的最后一天
        /// </summary>
        /// <param name="this">要获取月份最后一天的日期</param>
        /// <returns>当前日期所在月份的最后一天</returns>
        public static DateTime GetMonthLastDay(this DateTime @this)
        {
            var result = @this.GetMonthFirstDay().AddMonths(1).AddDays(-1);
            return result;
        }
    }
}
