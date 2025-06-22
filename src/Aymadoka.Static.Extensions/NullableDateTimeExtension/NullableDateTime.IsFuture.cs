using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTime?"/> 是否为将来的时间。
        /// </summary>
        /// <param name="this">要判断的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>如果为将来的时间则返回 <c>true</c>，否则返回 <c>false</c>。</returns>
        public static bool IsFuture(this DateTime? @this)
        {
            if (@this == null)
            {
                return false;
            }

            var result = @this.Value.IsFuture();
            return result;
        }
    }
}
