using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTime?"/> 距离 Unix 纪元的毫秒级时间戳。
        /// </summary>
        /// <param name="date">可空的 <see cref="DateTime"/> 实例。</param>
        /// <returns>如果 <paramref name="date"/> 为 null，则返回 null；否则返回自 Unix 纪元以来的毫秒数。</returns>
        public static long? GetMillisecondLevelTimeStamp(this DateTime? date)
        {
            if (date == null)
            {
                return null;
            }

            var result = (long)(date - DateTime.UnixEpoch).Value.TotalMilliseconds;
            return result;
        }
    }
}
