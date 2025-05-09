using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static long GetSecondLevelTimeStamp(this DateTime? date)
    {
        var result = (long)(date - DateTime.UnixEpoch).TotalSeconds;
        return result;
    }
}
