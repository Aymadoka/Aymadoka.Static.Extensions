using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset"/> 所在月份的倒数第二天
        /// </summary>
        /// <param name="this">要操作的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>该月份倒数第二天的 <see cref="DateTimeOffset"/></returns>
        public static DateTimeOffset GetMonthSecondDay(this DateTimeOffset @this)
        {
            var result = @this.GetMonthFirstDay().AddMonths(1).AddDays(-2);
            return result;
        }
    }
}
