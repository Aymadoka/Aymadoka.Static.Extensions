using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTime"/> 对象自 Unix 纪元（1970-01-01 00:00:00 UTC）以来的毫秒级时间戳
        /// </summary>
        /// <param name="date">要计算时间戳的 <see cref="DateTime"/> 对象</param>
        /// <returns>自 Unix 纪元以来的毫秒数</returns>
        public static long GetMillisecondLevelTimeStamp(this DateTime date)
        {
            var result = (long)(date - DateTime.UnixEpoch).TotalMilliseconds;
            return result;
        }
    }
}
