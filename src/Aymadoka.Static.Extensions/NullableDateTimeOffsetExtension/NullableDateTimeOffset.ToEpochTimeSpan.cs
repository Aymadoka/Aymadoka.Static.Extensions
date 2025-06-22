using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 将可空 <see cref="DateTimeOffset"/> 转换为自 Unix 纪元（1970-01-01 00:00:00 UTC）以来的 <see cref="TimeSpan"/>。
        /// </summary>
        /// <param name="this">要转换的可空 <see cref="DateTimeOffset"/> 实例。</param>
        /// <returns>如果 <paramref name="this"/> 为 null，则返回 null；否则返回自 Unix 纪元以来的 <see cref="TimeSpan"/>。</returns>
        public static TimeSpan? ToEpochTimeSpan(this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return null;
            }

            return @this.Value.ToEpochTimeSpan();
        }
    }
}
