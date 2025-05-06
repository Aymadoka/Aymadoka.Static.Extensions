using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static int? Age(this DateTime? @this)
    {
        if (@this == null)
        {
            return null;
        }

        return @this.Value.Age();
    }
}
