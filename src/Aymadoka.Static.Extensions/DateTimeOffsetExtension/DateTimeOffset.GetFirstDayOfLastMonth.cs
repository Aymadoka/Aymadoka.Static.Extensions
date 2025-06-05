using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset"/> 上个月的第一天
        /// </summary>
        /// <param name="this">要操作的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>上个月的第一天（时间部分与原始值相同）</returns>
        public static DateTimeOffset GetFirstDayOfLastMonth(this DateTimeOffset @this)
        {
            var result = @this.GetFirstDayOfMonth().AddMonths(-1);
            return result;
        }
    }
}
