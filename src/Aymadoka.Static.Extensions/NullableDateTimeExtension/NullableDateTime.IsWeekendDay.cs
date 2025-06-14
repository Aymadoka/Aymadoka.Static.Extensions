using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 判断可空 <see cref="DateTime"/> 是否为周末（星期六或星期日）。
        /// </summary>
        /// <param name="this">要判断的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>如果为周末返回 <c>true</c>，否则返回 <c>false</c>。如果为 <c>null</c>，返回 <c>false</c>。</returns>
        public static bool IsWeekendDay([NotNullWhen(true)] this DateTime? @this)
        {
            if (@this == null)
            {
                return false;
            }

            var result = @this.Value.IsWeekendDay();
            return result;
        }
    }
}
