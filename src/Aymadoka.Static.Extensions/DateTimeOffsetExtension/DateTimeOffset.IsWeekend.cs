using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTimeOffset"/> 是否为周末（星期六或星期日）
        /// </summary>
        /// <param name="this">要判断的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>如果是周末则返回 <c>true</c>，否则返回 <c>false</c></returns>
        public static bool IsWeekend(this DateTimeOffset @this)
        {
            var result = @this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday;
            return result;
        }
    }
}
