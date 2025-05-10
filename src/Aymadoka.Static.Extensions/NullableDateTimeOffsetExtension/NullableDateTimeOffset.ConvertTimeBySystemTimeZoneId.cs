using Aymadoka.Static.DateTimeOffsetExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        public static DateTimeOffset? ConvertTimeBySystemTimeZoneId(this DateTimeOffset? dateTimeOffset, string destinationTimeZoneId)
        {
            if (dateTimeOffset == null)
            {
                return null;
            }

            var result = dateTimeOffset.Value.ConvertTimeBySystemTimeZoneId(destinationTimeZoneId);
            return result;
        }
    }
}
