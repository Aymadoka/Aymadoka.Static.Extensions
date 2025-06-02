using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DateTime"/> 是否为今天
        /// </summary>
        /// <param name="this">要判断的日期时间</param>
        /// <returns>如果是今天则返回 <c>true</c>，否则返回 <c>false</c></returns>
        public static bool IsToday(this DateTime @this)
        {
            var result = @this.Date == DateTime.Today;
            return result;
        }
    }
}
