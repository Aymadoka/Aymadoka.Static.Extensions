using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        public static long GetSecondLevelTimeStamp(this DateTime date)
        {
            var result = (long)(date - DateTime.UnixEpoch).TotalSeconds;
            return result;
        }
    }
}
