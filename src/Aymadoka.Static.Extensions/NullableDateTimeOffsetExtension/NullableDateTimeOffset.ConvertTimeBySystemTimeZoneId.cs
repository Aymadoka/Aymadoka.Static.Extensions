using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 将可空 <see cref="DateTimeOffset"/> 按指定的系统时区 ID 进行时间转换。
        /// </summary>
        /// <param name="dateTimeOffset">要转换的可空 <see cref="DateTimeOffset"/> 实例。</param>
        /// <param name="destinationTimeZoneId">目标系统时区的标识符。</param>
        /// <returns>转换后的 <see cref="DateTimeOffset"/>，如果 <paramref name="dateTimeOffset"/> 为 null，则返回 null。</returns>
        public static DateTimeOffset? ConvertTimeBySystemTimeZoneId(this DateTimeOffset? dateTimeOffset, string destinationTimeZoneId)
        {
            if (dateTimeOffset == null)
            {
                return null;
            }

            var result = dateTimeOffset.Value.ConvertTimeBySystemTimeZoneId(destinationTimeZoneId);
            return result;
        }
    }
}
