using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static DateTime? SetTime(this DateTime? @this, int hour)
    {
        var result = @this.SetTime(hour, 0, 0, 0);
        return result;
    }

    public static DateTime? SetTime(this DateTime? @this, int hour, int minute)
    {
        var result = @this.SetTime(hour, minute, 0, 0);
        return result;
    }

    public static DateTime? SetTime(this DateTime? @this, int hour, int minute, int second)
    {
        var result = @this.SetTime(hour, minute, second, 0);
        return result;
    }

    public static DateTime? SetTime(this DateTime? @this, int hour, int minute, int second, int millisecond)
    {
        if (@this == null)
        {
            return default;
        }

        var result = @this.Value.SetTime(hour, minute, second, millisecond);
        return result;
    }
}
