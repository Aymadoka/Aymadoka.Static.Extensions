using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static long GetMillisecondLevelTimeStamp(this DateTime? date)
    {
        var result = (long)(date - DateTime.UnixEpoch).TotalMilliseconds;
        return result;
    }
}
