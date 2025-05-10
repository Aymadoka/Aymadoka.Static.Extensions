using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        public static bool IsFuture(this DateTime? @this)
        {
            if (@this == null)
            {
                return false;
            }

            var result = @this.Value.IsFuture();
            return result;
        }
    }
}
