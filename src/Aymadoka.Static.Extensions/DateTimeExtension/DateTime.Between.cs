using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static bool Between(this DateTime @this, DateTime minValue, DateTime maxValue)
    {
        return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
    }
}
