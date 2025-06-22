using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTime"/> 对象自 Unix 纪元（1970-01-01 00:00:00 UTC）以来的秒级时间戳
        /// </summary>
        /// <param name="date">要转换的 <see cref="DateTime"/> 对象</param>
        /// <returns>自 Unix 纪元以来的秒数</returns>
        public static long GetSecondLevelTimeStamp(this DateTime date)
        {
            // 确保时间为 UTC
            var utcDateTime = date.Kind == DateTimeKind.Utc ? date : date.ToUniversalTime();
            return (long)(utcDateTime - DateTime.UnixEpoch).TotalSeconds;
        }
    }
}
