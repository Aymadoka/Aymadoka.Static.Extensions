using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTimeOffset?"/> 是否为周末（星期六或星期日）。
        /// </summary>
        /// <param name="this">要判断的 <see cref="DateTimeOffset?"/> 实例。</param>
        /// <returns>如果为周末返回 <c>true</c>，否则返回 <c>false</c>。当值为 <c>null</c> 时返回 <c>false</c>。</returns>
        public static bool IsWeekend([NotNullWhen(true)] this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return false;
            }

            var result = @this.Value.IsWeekend();
            return result;
        }
    }
}
