using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static int Age(this DateTime @this)
    {
        if (DateTime.Today.Month < @this.Month ||
            DateTime.Today.Month == @this.Month &&
            DateTime.Today.Day < @this.Day)
        {
            return DateTime.Today.Year - @this.Year - 1;
        }

        return DateTime.Today.Year - @this.Year;
    }
}
