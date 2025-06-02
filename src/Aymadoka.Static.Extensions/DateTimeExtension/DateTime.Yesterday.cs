using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTime"/> 的前一天日期
        /// </summary>
        /// <param name="this">要获取前一天的日期</param>
        /// <returns>前一天的 <see cref="DateTime"/> 实例</returns>
        public static DateTime Yesterday(this DateTime @this)
        {
            var result = @this.AddDays(-1);
            return result;
        }
    }
}
