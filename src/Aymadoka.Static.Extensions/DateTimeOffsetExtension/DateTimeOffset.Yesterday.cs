using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset"/> 的前一天日期
        /// </summary>
        /// <param name="this">要获取前一天的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>前一天的 <see cref="DateTimeOffset"/></returns>
        public static DateTimeOffset Yesterday(this DateTimeOffset @this)
        {
            var result = @this.AddDays(-1);
            return result;
        }
    }
}
