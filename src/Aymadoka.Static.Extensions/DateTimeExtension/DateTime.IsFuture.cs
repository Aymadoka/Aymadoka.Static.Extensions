using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTime"/> 是否在当前时间之后（即是否为未来时间）
        /// </summary>
        /// <param name="this">要判断的 <see cref="DateTime"/> 实例</param>
        /// <returns>如果时间在当前时间之后，返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool IsFuture(this DateTime @this)
        {
            return @this > DateTime.Now;
        }
    }
}
