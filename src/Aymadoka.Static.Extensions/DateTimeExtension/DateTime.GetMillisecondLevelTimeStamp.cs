using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static long GetMillisecondLevelTimeStamp(this DateTime date)
    {
        var result = (long)(date - DateTime.UnixEpoch).TotalMilliseconds;
        return result;
    }
}
