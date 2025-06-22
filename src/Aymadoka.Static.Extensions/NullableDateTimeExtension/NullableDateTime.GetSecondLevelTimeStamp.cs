using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTime?"/> 对象的秒级时间戳（自 Unix 纪元以来的秒数）。
        /// </summary>
        /// <param name="date">可空的 <see cref="DateTime"/> 对象。</param>
        /// <returns>如果 <paramref name="date"/> 为 null，则返回 null；否则返回自 Unix 纪元以来的秒数。</returns>
        public static long? GetSecondLevelTimeStamp(this DateTime? date)
        {
            if (date == null)
            {
                return null;
            }

            var result = (long)(date - DateTime.UnixEpoch).Value.TotalSeconds;
            return result;
        }
    }
}
