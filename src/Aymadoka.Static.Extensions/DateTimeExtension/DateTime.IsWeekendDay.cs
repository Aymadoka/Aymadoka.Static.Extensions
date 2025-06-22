using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {

        /// <summary>
        /// 判断指定的 <see cref="DateTime"/> 是否为周末（星期六或星期日）
        /// </summary>
        /// <param name="this">要判断的日期</param>
        /// <returns>如果是周末返回 <c>true</c>，否则返回 <c>false</c></returns>
        public static bool IsWeekendDay(this DateTime @this)
        {
            var result = @this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday;
            return result;
        }
    }
}
