using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 返回指定 <see cref="DateTime"/> 的明天日期
        /// </summary>
        /// <param name="this">要获取明天日期的 <see cref="DateTime"/> 实例</param>
        /// <returns>指定日期的下一天</returns>
        public static DateTime Tomorrow(this DateTime @this)
        {
            var result = @this.AddDays(1);
            return result;
        }
    }
}
