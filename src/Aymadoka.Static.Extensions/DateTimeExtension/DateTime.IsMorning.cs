using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTime"/> 是否为上午（00:00:00 ~ 11:59:59）
        /// </summary>
        /// <param name="this">要判断的 <see cref="DateTime"/> 实例</param>
        /// <returns>如果时间在上午则返回 <c>true</c>，否则返回 <c>false</c></returns>
        public static bool IsMorning(this DateTime @this)
        {
            var kind = @this.Kind;
            var result = @this.TimeOfDay < new DateTime(2000, 1, 1, 12, 0, 0, kind).TimeOfDay;
            return result;
        }
    }
}
