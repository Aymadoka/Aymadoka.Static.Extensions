using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 移除可空 <see cref="DateTime"/> 的时间部分，仅保留日期部分。
        /// </summary>
        /// <param name="this">要处理的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>如果 <paramref name="this"/> 为 null，则返回 null；否则返回移除时间部分后的 <see cref="DateTime"/>。</returns>
        public static DateTime? RemoveTime([NotNullIfNotNull(nameof(@this))] this DateTime? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.RemoveTime();
            return result;
        }
    }
}
