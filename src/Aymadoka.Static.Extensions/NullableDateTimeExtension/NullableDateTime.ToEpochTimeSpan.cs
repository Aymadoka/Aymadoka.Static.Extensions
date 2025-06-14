using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 将可空 <see cref="DateTime"/> 转换为自 Unix 纪元以来的 <see cref="TimeSpan"/>。
        /// </summary>
        /// <param name="this">要转换的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>自 Unix 纪元以来的 <see cref="TimeSpan"/>，如果为 null 则返回 null。</returns>
        public static TimeSpan? ToEpochTimeSpan(this DateTime? @this)
        {
            if (@this == null)
            {
                return null;
            }

            return @this.Value.ToEpochTimeSpan();
        }
    }
}
