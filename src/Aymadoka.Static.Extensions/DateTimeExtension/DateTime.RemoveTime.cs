using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 移除 <see cref="DateTime"/> 实例的时间部分，仅保留日期部分，时间将被重置为 00:00:00
        /// </summary>
        /// <param name="this">要处理的 <see cref="DateTime"/> 实例</param>
        /// <returns>仅包含日期部分的新 <see cref="DateTime"/> 实例</returns>
        public static DateTime RemoveTime(this DateTime @this)
        {
            var result = @this.Date;
            return result;
        }
    }
}
