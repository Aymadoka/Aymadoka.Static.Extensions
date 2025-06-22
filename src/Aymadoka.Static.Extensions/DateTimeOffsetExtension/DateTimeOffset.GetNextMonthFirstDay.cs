using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset"/> 的下一个月的第一天
        /// </summary>
        /// <param name="this">要获取下一个月第一天的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>下一个月第一天的 <see cref="DateTimeOffset"/></returns>
        public static DateTimeOffset GetNextMonthFirstDay(this DateTimeOffset @this)
        {
            var result = @this.GetMonthFirstDay().AddMonths(1);
            return result;
        }
    }
}
