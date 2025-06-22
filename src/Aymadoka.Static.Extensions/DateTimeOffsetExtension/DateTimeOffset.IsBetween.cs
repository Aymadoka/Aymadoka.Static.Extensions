using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 判断当前 <see cref="DateTimeOffset"/> 是否在指定的起始和结束时间之间（包含边界）
        /// </summary>
        /// <param name="this">要判断的 <see cref="DateTimeOffset"/> 实例</param>
        /// <param name="start">起始时间（包含）</param>
        /// <param name="end">结束时间（包含）</param>
        /// <returns>如果当前时间在起始和结束时间之间（包含边界），返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool IsBetween(this DateTimeOffset @this, DateTimeOffset start, DateTimeOffset end)
        {
            return @this >= start && @this <= end;
        }
    }
}
