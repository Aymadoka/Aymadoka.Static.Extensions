using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTime"/> 是否为工作日（周一至周五）
        /// </summary>
        /// <param name="this">要判断的日期</param>
        /// <returns>如果是工作日返回 <c>true</c>，否则返回 <c>false</c></returns>
        public static bool IsWeekDay(this DateTime @this)
        {
            var result = !@this.IsWeekendDay();
            return result;
        }
    }
}
