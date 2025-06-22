using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 设置 <see cref="DateTime?"/> 的小时部分，分钟、秒和毫秒均为 0。
        /// </summary>
        /// <param name="this">要设置时间的可空 <see cref="DateTime"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <returns>设置后的 <see cref="DateTime?"/>，如果原值为 null，则返回 null。</returns>
        public static DateTime? SetTime(this DateTime? @this, int hour)
        {
            var result = @this.SetTime(hour, 0, 0, 0);
            return result;
        }

        /// <summary>
        /// 设置 <see cref="DateTime?"/> 的小时和分钟部分，秒和毫秒为 0。
        /// </summary>
        /// <param name="this">要设置时间的可空 <see cref="DateTime"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <returns>设置后的 <see cref="DateTime?"/>，如果原值为 null，则返回 null。</returns>
        public static DateTime? SetTime(this DateTime? @this, int hour, int minute)
        {
            var result = @this.SetTime(hour, minute, 0, 0);
            return result;
        }

        /// <summary>
        /// 设置 <see cref="DateTime?"/> 的小时、分钟和秒部分，毫秒为 0。
        /// </summary>
        /// <param name="this">要设置时间的可空 <see cref="DateTime"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <param name="second">要设置的秒。</param>
        /// <returns>设置后的 <see cref="DateTime?"/>，如果原值为 null，则返回 null。</returns>
        public static DateTime? SetTime(this DateTime? @this, int hour, int minute, int second)
        {
            var result = @this.SetTime(hour, minute, second, 0);
            return result;
        }

        /// <summary>
        /// 设置 <see cref="DateTime?"/> 的小时、分钟、秒和毫秒部分。
        /// </summary>
        /// <param name="this">要设置时间的可空 <see cref="DateTime"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <param name="second">要设置的秒。</param>
        /// <param name="millisecond">要设置的毫秒。</param>
        /// <returns>设置后的 <see cref="DateTime?"/>，如果原值为 null，则返回 null。</returns>
        public static DateTime? SetTime(this DateTime? @this, int hour, int minute, int second, int millisecond)
        {
            if (@this == null)
            {
                return default;
            }

            var result = @this.Value.SetTime(hour, minute, second, millisecond);
            return result;
        }
    }
}
