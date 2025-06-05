using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 计算指定 <see cref="DateTimeOffset"/> 与 Unix 纪元（1970-01-01T00:00:00Z）之间的时间间隔
        /// </summary>
        /// <param name="this">要计算的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>自 Unix 纪元以来的 <see cref="TimeSpan"/></returns>
        public static TimeSpan ToEpochTimeSpan(this DateTimeOffset @this)
        {
            return @this.Subtract(DateTimeOffset.UnixEpoch);
        }
    }
}
