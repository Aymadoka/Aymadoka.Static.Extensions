using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断两个 <see cref="DateTime"/> 实例的日期部分是否相等（忽略时间部分）
        /// </summary>
        /// <param name="date">要比较的第一个日期</param>
        /// <param name="dateToCompare">要比较的第二个日期</param>
        /// <returns>如果日期部分相等，则返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
        {
            return (date.Date == dateToCompare.Date);
        }
    }
}
