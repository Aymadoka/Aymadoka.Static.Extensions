using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取当前日期所在月份的第一天
        /// </summary>
        /// <param name="this">要获取月份第一天的日期</param>
        /// <returns>当前日期所在月份的第一天</returns>
        public static DateTime GetMonthFirstDay(this DateTime @this)
        {
            var result = @this.AddDays(1 - @this.Day);
            return result;
        }
    }
}
