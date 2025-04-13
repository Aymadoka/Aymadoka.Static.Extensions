using System;

namespace Aymadok.Static.DateTimeExtension
{
    public static class NullableDateTimeExtensions
    {
        /// <summary>
        /// 格式化一个可空的日期
        /// </summary>
        /// <param name="sourceDateTime"></param>
        /// <param name="formatString">格式化模板</param>
        /// <returns></returns>
        public static string? ToString(this DateTime? sourceDateTime, string formatString)
        {
            if (sourceDateTime.HasValue)
            {
                return sourceDateTime.Value.ToString(formatString);
            }
            else
            {
                return null;
            }
        }

        /// <summary>获取传入时间当天的指定时间</summary>
        /// <param name="sourceDateTime">传入时间</param>
        /// <param name="hours">不传为当日零时零分零秒</param>
        /// <returns></returns>
        public static DateTime? CurrentDay(this DateTime? sourceDateTime, double? hours = null)
        {
            if (sourceDateTime.HasValue)
            {
                return sourceDateTime.Value.CurrentDay();
            }

            return null;
        }

        /// <summary>
        /// 获取传入时间的下一天
        /// </summary>
        /// <param name="sourceDateTime"></param>
        /// <returns></returns>
        public static DateTime? NextDay(this DateTime? sourceDateTime)
        {
            if (sourceDateTime.HasValue)
            {
                return sourceDateTime.Value.NextDay();
            }

            return null;
        }

        /// <summary>
        /// 获取传入时间的上一天
        /// </summary>
        /// <param name="sourceDateTime"></param>
        /// <returns></returns>
        public static DateTime? PreviousDay(this DateTime? sourceDateTime)
        {
            if (sourceDateTime.HasValue)
            {
                return sourceDateTime.Value.PreviousDay();
            }

            return null;
        }

        /// <summary>
        /// 获取传入时间的 当月第一天零时零分零秒
        /// </summary>
        /// <param name="sourceDateTime"></param>
        /// <returns></returns>
        public static DateTime? CurrentMonthFirstDay(this DateTime? sourceDateTime)
        {
            if (sourceDateTime.HasValue)
            {
                return sourceDateTime.Value.CurrentMonthFirstDay();
            }

            return null;
        }

        /// <summary>
        /// 获取传入时间的 下月第一天零时零分零秒
        /// </summary>
        /// <param name="sourceDateTime"></param>
        /// <returns></returns>
        public static DateTime? GetFirstDayOfNextMonth(this DateTime? sourceDateTime)
        {
            if (sourceDateTime.HasValue)
            {
                return sourceDateTime.Value.GetFirstDayOfNextMonth();
            }

            return null;
        }

        /// <summary>获取时间戳</summary>
        public static long? GetTimeStamp(this DateTime? sourceDateTime)
        {
            if (sourceDateTime.HasValue)
            {
                return sourceDateTime.Value.GetTimeStamp();
            }

            return null;
        }
    }
}
