using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension;

public static partial class NullableDateTimeOffsetExtensions
{
    public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour)
    {
        return SetTime(current, hour, 0, 0, 0);
    }

    public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour, int minute)
    {
        return SetTime(current, hour, minute, 0, 0);
    }

    public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour, int minute, int second)
    {
        return SetTime(current, hour, minute, second, 0);
    }

    public static DateTimeOffset? SetTime(this DateTimeOffset? current, int hour, int minute, int second, int millisecond)
    {
        if (current == null)
        {
            return null;
        }

        var result = current.Value.SetTime(hour, minute, second, millisecond);
        return result;
    }
}