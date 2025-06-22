using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取当前日期上个月的第一天
        /// </summary>
        /// <param name="this">当前日期</param>
        /// <returns>上个月的第一天</returns>
        public static DateTime GetLastMonthFirstDay(this DateTime @this)
        {
            var result = @this.GetMonthFirstDay().AddMonths(-1);
            return result;
        }
    }
}
