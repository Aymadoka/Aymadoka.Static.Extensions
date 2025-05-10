using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {

        /// <summary>
        /// 获取 <see cref="DateTimeOffset"/> 的前一天日期。
        /// </summary>
        /// <param name="this">要获取前一天的 <see cref="DateTimeOffset"/>。</param>
        /// <returns>前一天的 <see cref="DateTimeOffset"/>。</returns>
        /// <remarks>
        /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
        /// - 如果输入日期为某月的第一天，返回的日期将是上个月的最后一天。
        /// </remarks>
        public static DateTimeOffset Yesterday(this DateTimeOffset @this)
        {
            var result = @this.AddDays(-1);
            return result;
        }
    }
}
