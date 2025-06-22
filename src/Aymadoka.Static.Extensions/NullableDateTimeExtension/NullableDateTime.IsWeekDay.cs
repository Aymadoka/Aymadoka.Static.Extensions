using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 判断可空 <see cref="DateTime"/> 是否为工作日（周一至周五）。
        /// </summary>
        /// <param name="this">要判断的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>
        /// 如果 <paramref name="this"/> 不为 null 且为工作日，则返回 <c>true</c>；否则返回 <c>false</c>。
        /// </returns>
        public static bool IsWeekDay(this DateTime? @this)
        {
            if (@this == null)
            {
                return false;
            }

            var result = @this.Value.IsWeekDay();
            return result;
        }
    }
}
