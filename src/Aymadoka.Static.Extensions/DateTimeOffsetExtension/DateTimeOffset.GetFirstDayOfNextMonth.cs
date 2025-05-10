using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在日期的下一个月的第一天日期。
        /// </summary>
        /// <param name="this">要获取下一个月第一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>下一个月第一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset GetFirstDayOfNextMonth(this DateTimeOffset @this)
        {
            var result = @this.CurrentMonthFirstDay().AddMonths(1);
            return result;
        }
    }
}
