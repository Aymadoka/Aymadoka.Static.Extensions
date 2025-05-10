using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 的下一天日期。
        /// </summary>
        /// <param name="this">要获取下一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>下一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// </remarks>
        public static DateTimeOffset Tomorrow(this DateTimeOffset @this)
        {
            var result = @this.AddDays(1);
            return result;
        }
    }
}
