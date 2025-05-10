using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 所在月份的第一天日期。
        /// </summary>
        /// <param name="this">要获取所在月份第一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>所在月份第一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset CurrentMonthFirstDay(this DateTimeOffset @this)
        {
            var result = @this.AddDays(1 - @this.Day);
            return result;
        }
    }
}
