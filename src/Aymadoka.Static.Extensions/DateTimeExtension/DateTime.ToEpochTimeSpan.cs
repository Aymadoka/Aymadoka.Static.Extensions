using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 计算指定 <see cref="DateTime"/> 与 Unix 纪元（1970-01-01 00:00:00 UTC）之间的时间间隔
        /// </summary>
        /// <param name="this">要计算的 <see cref="DateTime"/> 实例</param>
        /// <returns>与 Unix 纪元之间的 <see cref="TimeSpan"/></returns>
        public static TimeSpan ToEpochTimeSpan(this DateTime @this)
        {
            return @this.Subtract(DateTime.UnixEpoch);
        }
    }
}
