using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset"/> 的毫秒级 Unix 时间戳
        /// </summary>
        /// <param name="this">要获取时间戳的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>自 1970-01-01 00:00:00 UTC 起经过的毫秒数</returns>
        public static long GetMillisecondLevelTimeStamp(this DateTimeOffset @this)
        {
            var result = @this.ToUnixTimeMilliseconds();
            return result;
        }
    }
}
