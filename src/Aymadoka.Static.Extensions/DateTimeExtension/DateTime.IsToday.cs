using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        public static bool IsToday(this DateTime @this)
        {
            var result = @this.Date == DateTime.Today;
            return result;
        }
    }
}
