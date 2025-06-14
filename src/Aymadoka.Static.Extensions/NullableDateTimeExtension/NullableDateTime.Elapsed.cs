using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 计算指定可空 <see cref="DateTime"/> 到当前时间的时间间隔。
        /// </summary>
        /// <param name="datetime">要计算的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>从指定时间到现在的 <see cref="TimeSpan"/>。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="datetime"/> 为 null 时抛出。</exception>
        public static TimeSpan Elapsed(this DateTime? datetime)
        {
            if (datetime == null)
            {
                throw new ArgumentNullException(nameof(datetime));
            }

            var result = datetime.Value.Elapsed();
            return result;
        }
    }
}
