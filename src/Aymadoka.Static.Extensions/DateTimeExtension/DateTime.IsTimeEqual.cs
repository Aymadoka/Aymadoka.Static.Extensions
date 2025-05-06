using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
    {
        var result = (time.TimeOfDay == timeToCompare.TimeOfDay);
        return result;
    }
}
