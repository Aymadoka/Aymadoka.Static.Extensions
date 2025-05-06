using System;

namespace Aymadoka.Static.DateTimeOffsetExtension;

public static partial class DateTimeOffsetExtensions
{
    public static DateTimeOffset ConvertTime(this DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
    {
        return TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
    }
}
