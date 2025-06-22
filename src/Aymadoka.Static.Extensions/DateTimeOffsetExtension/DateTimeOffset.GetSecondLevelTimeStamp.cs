using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取当前 <see cref="DateTimeOffset"/> 的秒级时间戳（自1970-01-01 00:00:00 UTC以来的秒数）
        /// </summary>
        /// <param name="this">要获取时间戳的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>秒级时间戳（long 类型）</returns>
        public static long GetSecondLevelTimeStamp(this DateTimeOffset @this)
        {
            var result = @this.ToUnixTimeSeconds();
            return result;
        }
    }
}
