using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        public static TimeSpan? ToEpochTimeSpan(this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return null;
            }

            return @this.Value.ToEpochTimeSpan();
        }
    }
}
