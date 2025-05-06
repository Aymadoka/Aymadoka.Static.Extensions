using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static TimeSpan? ToEpochTimeSpan(this DateTime? @this)
    {
        if (@this == null)
        {
            return null;
        }

        return @this.Value.ToEpochTimeSpan();
    }
}
