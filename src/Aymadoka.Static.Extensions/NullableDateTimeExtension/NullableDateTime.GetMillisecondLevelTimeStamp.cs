using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        public static long? GetMillisecondLevelTimeStamp(this DateTime? date)
        {
            if (date == null)
            {
                return null;
            }

            var result = (long)(date - DateTime.UnixEpoch).Value.TotalMilliseconds;
            return result;
        }
    }
}
