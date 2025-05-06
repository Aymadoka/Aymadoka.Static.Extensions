using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension;

public static partial class NullableDateTimeOffsetExtensions
{
    public static DateTimeOffset? ConvertTime(this DateTimeOffset? dateTimeOffset, TimeZoneInfo destinationTimeZone)
    {
        if (dateTimeOffset == null)
        {
            return null;
        }

        var result = dateTimeOffset.Value.ConvertTime(destinationTimeZone);
        return result;
    }
}
