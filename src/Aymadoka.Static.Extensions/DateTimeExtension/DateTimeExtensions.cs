using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static class DateTimeExtensions
    {
        public static bool IsMinValue(this DateTime sourceDateTime)
        {
            var result = sourceDateTime == DateTime.MinValue;
            return result;
        }

        public static DateTime NextDay(this DateTime sourceDateTime)
        {
            var result = sourceDateTime.Date.AddDays(1);
            return result;
        }

        public static DateTime PreviousDay(this DateTime sourceDateTime)
        {
            var result = sourceDateTime.Date.AddDays(-1);
            return result;
        }

        public static DateTime GetFirstDayOfMonth(this DateTime sourceDateTime)
        {
            var result = sourceDateTime.AddDays(1 - sourceDateTime.Day).Date;
            return result;
        }

        public static DateTime GetFirstDayOfNextMonth(this DateTime sourceDateTime)
        {
            var result = sourceDateTime.AddDays(1 - sourceDateTime.Day).Date.AddMonths(1);
            return result;
        }

        public static DateTime GetFirstDayOfLastMonth(this DateTime sourceDateTime)
        {
            var result = sourceDateTime.AddDays(1 - sourceDateTime.Day).Date.AddMonths(-1);
            return result;
        }

        public static DateTime GetLastDayOfMonth(this DateTime sourceDateTime)
        {
            var result = sourceDateTime.AddDays(1 - sourceDateTime.Day).Date.AddMonths(1).AddDays(-1);
            return result;
        }

        public static DateTime GetSecondDayToLastOfMonth(this DateTime sourceDateTime)
        {
            var result = sourceDateTime.AddDays(1 - sourceDateTime.Day).Date.AddMonths(1).AddDays(-2);
            return result;
        }

        public static DateTime CurrentMonthFirstDay(this DateTime dt)
        {
            var result = new DateTime(dt.Year, dt.Month, 1);
            return result;
        }

        public static DateTime CurrentMonthLastDay(this DateTime dt)
        {
            var result = dt.CurrentMonthFirstDay().AddMonths(1).AddMilliseconds(-1);
            return result;
        }

        public static DateTime CurrentDay(this DateTime sourceDateTime, double? hours = null)
        {
            var result = sourceDateTime.Date;
            if (hours.HasValue)
            {
                result = result.AddHours(hours.Value);
            }
            return result;
        }

        public static bool IsWeekend(this DateTime dt)
        {
            var result = dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;
            return result;
        }

        public static long GetTimeStamp(this DateTime sourceDateTime)
        {
            var timeStamp = new DateTimeOffset(sourceDateTime).ToUnixTimeSeconds();
            return timeStamp;
        }
    }
}
