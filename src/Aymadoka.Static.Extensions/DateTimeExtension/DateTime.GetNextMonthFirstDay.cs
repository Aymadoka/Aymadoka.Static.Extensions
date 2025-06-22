using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取下一个月的第一天
        /// </summary>
        /// <param name="this">当前日期</param>
        /// <returns>下一个月的第一天的 <see cref="DateTime"/> 实例</returns>
        public static DateTime GetNextMonthFirstDay(this DateTime @this)
        {
            var result = @this.GetMonthFirstDay().AddMonths(1);
            return result;
        }
    }
}
