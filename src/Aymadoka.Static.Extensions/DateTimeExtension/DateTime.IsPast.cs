using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTime"/> 是否早于当前系统时间
        /// </summary>
        /// <param name="this">要判断的 <see cref="DateTime"/> 实例</param>
        /// <returns>如果时间早于当前时间，返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool IsPast(this DateTime @this)
        {
            return @this < DateTime.Now;
        }
    }
}
