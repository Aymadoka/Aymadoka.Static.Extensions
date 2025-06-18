using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 尝试将字符串转换为有效的 <see cref="DateTime"/>，如果转换失败则返回 <c>null</c>。
        /// </summary>
        /// <param name="this">要转换的字符串。</param>
        /// <returns>转换成功时返回 <see cref="DateTime"/>，否则返回 <c>null</c>。</returns>
        public static DateTime? ToValidDateTimeOrNull(this string @this)
        {
            DateTime date;

            if (DateTime.TryParse(@this, out date))
            {
                return date;
            }

            return null;
        }
    }
}
