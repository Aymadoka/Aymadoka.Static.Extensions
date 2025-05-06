using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static TimeSpan Elapsed(this DateTime? datetime)
    {
        if (datetime == null)
        {
            throw new ArgumentNullException(nameof(datetime));
        }

        var result = datetime.Value.Elapsed();
        return result;
    }
}
