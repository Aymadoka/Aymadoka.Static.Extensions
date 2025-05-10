using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        public static bool IsMorning(this DateTime @this)
        {
            var kind = @this.Kind;
            var result = @this.TimeOfDay < new DateTime(2000, 1, 1, 12, 0, 0, kind).TimeOfDay;
            return result;
        }
    }
}
