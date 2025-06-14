using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset"/> 所在月份的最后一天
        /// </summary>
        /// <param name="this">要获取最后一天的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>该月份的最后一天，时间部分与原始值相同</returns>
        public static DateTimeOffset GetMonthLastDay(this DateTimeOffset @this)
        {
            var result = @this.GetMonthFirstDay().AddMonths(1).AddDays(-1);
            return result;
        }
    }
}
