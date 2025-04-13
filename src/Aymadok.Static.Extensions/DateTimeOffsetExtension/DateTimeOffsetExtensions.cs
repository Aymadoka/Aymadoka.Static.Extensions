using System;

namespace Aymadok.Static.DateTimeOffsetExtension
{
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 将 DateTimeOffset 转换为指定时区的时间。
        /// </summary>
        /// <param name="dateTimeOffset">要转换的 DateTimeOffset。</param>
        /// <param name="timeZoneId">目标时区的标识符。</param>
        /// <returns>转换后的 DateTimeOffset。</returns>
        public static DateTimeOffset ToTimeZone(this DateTimeOffset dateTimeOffset, string timeZoneId)
        {
            if (string.IsNullOrWhiteSpace(timeZoneId))
                throw new ArgumentException("时区标识符不能为空", nameof(timeZoneId));

            var timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTime(dateTimeOffset, timeZone);
        }

        /// <summary>
        /// 判断给定的 DateTimeOffset 是否在指定的时间范围内。
        /// </summary>
        /// <param name="dateTimeOffset">要检查的 DateTimeOffset。</param>
        /// <param name="start">范围的开始时间。</param>
        /// <param name="end">范围的结束时间。</param>
        /// <returns>如果在范围内，则返回 true；否则返回 false。</returns>
        public static bool IsBetween(this DateTimeOffset dateTimeOffset, DateTimeOffset start, DateTimeOffset end)
        {
            return dateTimeOffset >= start && dateTimeOffset <= end;
        }

        /// <summary>
        /// 获取 DateTimeOffset 的 Unix 时间戳（秒）。
        /// </summary>
        /// <param name="dateTimeOffset">要转换的 DateTimeOffset。</param>
        /// <returns>Unix 时间戳。</returns>
        public static long ToUnixTimeSeconds(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.ToUnixTimeSeconds();
        }

        /// <summary>
        /// 获取 DateTimeOffset 的 Unix 时间戳（毫秒）。
        /// </summary>
        /// <param name="dateTimeOffset">要转换的 DateTimeOffset。</param>
        /// <returns>Unix 时间戳。</returns>
        public static long ToUnixTimeMilliseconds(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// 将 DateTimeOffset 设置为当天的开始时间（00:00:00）。
        /// </summary>
        /// <param name="dateTimeOffset">要设置的 DateTimeOffset。</param>
        /// <returns>当天开始时间的 DateTimeOffset。</returns>
        public static DateTimeOffset StartOfDay(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.Date;
        }

        /// <summary>
        /// 将 DateTimeOffset 设置为当天的结束时间（23:59:59.999）。
        /// </summary>
        /// <param name="dateTimeOffset">要设置的 DateTimeOffset。</param>
        /// <returns>当天结束时间的 DateTimeOffset。</returns>
        public static DateTimeOffset EndOfDay(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.Date.AddDays(1).AddTicks(-1);
        }
    }
}
