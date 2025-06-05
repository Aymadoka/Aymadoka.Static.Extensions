using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 移除 <see cref="DateTimeOffset"/> 的时间部分，仅保留日期部分（时分秒均为零）
        /// </summary>
        /// <param name="this">要处理的 <see cref="DateTimeOffset"/> 实例</param>
        /// <returns>仅包含日期部分的 <see cref="DateTimeOffset"/></returns>
        public static DateTimeOffset RemoveTime(this DateTimeOffset @this)
        {
            var timeOfDay = @this.TimeOfDay;
            var result = @this - timeOfDay;
            return result;
        }
    }
}
