using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 计算自指定 <see cref="DateTime"/> 到当前 UTC 时间的时间间隔
        /// </summary>
        /// <param name="datetime">要计算的起始 <see cref="DateTime"/></param>
        /// <returns>从 <paramref name="datetime"/> 到当前 UTC 时间的 <see cref="TimeSpan"/></returns>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.UtcNow - datetime;
        }
    }
}
