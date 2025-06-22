using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 返回指定 <see cref="DateTimeOffset"/> 的明天日期（即加一天）
        /// </summary>
        /// <param name="this">要计算明天的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>加一天后的 <see cref="DateTimeOffset"/> 实例</returns>
        public static DateTimeOffset Tomorrow(this DateTimeOffset @this)
        {
            var result = @this.AddDays(1);
            return result;
        }
    }
}
