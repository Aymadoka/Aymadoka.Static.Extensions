using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 将当前 <see cref="DateTimeOffset"/> 转换为指定时区的时间。
        /// </summary>
        /// <param name="dateTimeOffset">要转换的 <see cref="DateTimeOffset"/> 实例。</param>
        /// <param name="destinationTimeZoneId">目标时区的系统时区标识符。</param>
        /// <returns>转换为目标时区的 <see cref="DateTimeOffset"/>。</returns>
        public static DateTimeOffset ConvertTimeBySystemTimeZoneId(this DateTimeOffset dateTimeOffset, string destinationTimeZoneId)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId);
        }
    }
}
