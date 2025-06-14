using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 判断指定的可空 <see cref="DateTime"/> 是否为下午。
        /// </summary>
        /// <param name="this">要判断的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>如果为下午则返回 <c>true</c>，否则返回 <c>false</c>。如果为 <c>null</c>，返回 <c>false</c>。</returns>
        public static bool IsAfternoon(this DateTime? @this)
        {
            if (@this == null)
            {
                return false;
            }

            var result = @this.Value.IsAfternoon();
            return result;
        }
    }
}
