using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 设置当前日期的时间（小时），分钟、秒和毫秒均为0。
        /// </summary>
        /// <param name="current">当前日期。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <returns>返回设置后的新的 <see cref="DateTime"/> 实例。</returns>
        public static DateTime SetTime(this DateTime current, int hour)
        {
            var result = SetTime(current, hour, 0, 0, 0);
            return result;
        }

        /// <summary>
        /// 设置当前日期的时间（小时和分钟），秒和毫秒均为0。
        /// </summary>
        /// <param name="current">当前日期。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <returns>返回设置后的新的 <see cref="DateTime"/> 实例。</returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute)
        {
            var result = SetTime(current, hour, minute, 0, 0);
            return result;
        }

        /// <summary>
        /// 设置当前日期的时间（小时、分钟和秒），毫秒为0。
        /// </summary>
        /// <param name="current">当前日期。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <param name="second">要设置的秒。</param>
        /// <returns>返回设置后的新的 <see cref="DateTime"/> 实例。</returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
        {
            var result = SetTime(current, hour, minute, second, 0);
            return result;
        }

        /// <summary>
        /// 设置当前日期的时间（小时、分钟、秒和毫秒）。
        /// </summary>
        /// <param name="this">当前日期。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <param name="second">要设置的秒。</param>
        /// <param name="millisecond">要设置的毫秒。</param>
        /// <returns>返回设置后的新的 <see cref="DateTime"/> 实例。</returns>
        public static DateTime SetTime(this DateTime @this, int hour, int minute, int second, int millisecond)
        {
            var result = new DateTime(@this.Year, @this.Month, @this.Day, hour, minute, second, millisecond, @this.Kind);
            return result;
        }
    }
}
