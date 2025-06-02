using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取当前日期所在月份的倒数第二天的日期
        /// </summary>
        /// <param name="this">要操作的 <see cref="DateTime"/> 实例</param>
        /// <returns>该月份倒数第二天的 <see cref="DateTime"/></returns>
        public static DateTime GetLastOfMonthSecondDay(this DateTime @this)
        {
            var result = @this.CurrentMonthFirstDay().AddMonths(1).AddDays(-2);
            return result;
        }
    }
}
