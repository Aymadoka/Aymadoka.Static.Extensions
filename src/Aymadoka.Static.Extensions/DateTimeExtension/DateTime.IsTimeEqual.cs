using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断两个 <see cref="DateTime"/> 实例的时间部分（时分秒）是否相等
        /// </summary>
        /// <param name="time">要比较的第一个 <see cref="DateTime"/> 实例</param>
        /// <param name="timeToCompare">要比较的第二个 <see cref="DateTime"/> 实例</param>
        /// <returns>如果两个时间的 <c>TimeOfDay</c> 相等，则返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
        {
            var result = (time.TimeOfDay == timeToCompare.TimeOfDay);
            return result;
        }
    }
}
