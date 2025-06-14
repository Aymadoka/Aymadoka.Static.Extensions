using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 设置 <see cref="DateTimeOffset?"/> 的小时部分，分钟、秒和毫秒均为 0。
        /// </summary>
        /// <param name="current">当前可空 <see cref="DateTimeOffset"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <returns>设置后的 <see cref="DateTimeOffset?"/>，如果 <paramref name="current"/> 为 null，则返回 null。</returns>
        public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour)
        {
            return SetTime(current, hour, 0, 0, 0);
        }

        /// <summary>
        /// 设置 <see cref="DateTimeOffset?"/> 的小时和分钟部分，秒和毫秒为 0。
        /// </summary>
        /// <param name="current">当前可空 <see cref="DateTimeOffset"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <returns>设置后的 <see cref="DateTimeOffset?"/>，如果 <paramref name="current"/> 为 null，则返回 null。</returns>
        public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour, int minute)
        {
            return SetTime(current, hour, minute, 0, 0);
        }

        /// <summary>
        /// 设置 <see cref="DateTimeOffset?"/> 的小时、分钟和秒部分，毫秒为 0。
        /// </summary>
        /// <param name="current">当前可空 <see cref="DateTimeOffset"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <param name="second">要设置的秒。</param>
        /// <returns>设置后的 <see cref="DateTimeOffset?"/>，如果 <paramref name="current"/> 为 null，则返回 null。</returns>
        public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour, int minute, int second)
        {
            return SetTime(current, hour, minute, second, 0);
        }

        /// <summary>
        /// 设置 <see cref="DateTimeOffset?"/> 的小时、分钟、秒和毫秒部分。
        /// </summary>
        /// <param name="current">当前可空 <see cref="DateTimeOffset"/> 实例。</param>
        /// <param name="hour">要设置的小时。</param>
        /// <param name="minute">要设置的分钟。</param>
        /// <param name="second">要设置的秒。</param>
        /// <param name="millisecond">要设置的毫秒。</param>
        /// <returns>设置后的 <see cref="DateTimeOffset?"/>，如果 <paramref name="current"/> 为 null，则返回 null。</returns>
        public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour, int minute, int second, int millisecond)
        {
            if (current == null)
            {
                return null;
            }

            var result = current.Value.SetTime(hour, minute, second, millisecond);
            return result;
        }
    }
}