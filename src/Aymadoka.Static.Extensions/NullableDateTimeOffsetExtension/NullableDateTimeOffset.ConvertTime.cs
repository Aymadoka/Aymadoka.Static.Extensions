using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 将可空 <see cref="DateTimeOffset"/> 转换为指定时区的时间。
        /// </summary>
        /// <param name="dateTimeOffset">要转换的可空 <see cref="DateTimeOffset"/>。</param>
        /// <param name="destinationTimeZone">目标时区信息。</param>
        /// <returns>转换后的 <see cref="DateTimeOffset"/>，如果 <paramref name="dateTimeOffset"/> 为 null，则返回 null。</returns>
        public static DateTimeOffset? ConvertTime(this DateTimeOffset? dateTimeOffset, TimeZoneInfo destinationTimeZone)
        {
            if (dateTimeOffset == null)
            {
                return null;
            }

            var result = dateTimeOffset.Value.ConvertTime(destinationTimeZone);
            return result;
        }
    }
}
