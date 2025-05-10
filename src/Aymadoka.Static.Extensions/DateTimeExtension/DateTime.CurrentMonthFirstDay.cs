using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>获取指定日期所在月份的第一天</summary>
        /// <param name="dt">源日期</param>
        /// <returns>源日期所在月份的第一天，保留时间部分</returns>
        public static DateTime CurrentMonthFirstDay(this DateTime @this)
        {
            var result = @this.AddDays(1 - @this.Day);
            return result;
        }
    }
}
