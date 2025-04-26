using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public static class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 使用指定的格式将可空的 <see cref="DateTime"/> 转换为其字符串表示形式。
        /// </summary>
        /// <param name="sourceDateTime">要转换的可空 <see cref="DateTime"/>。</param>
        /// <param name="format">标准或自定义的日期和时间格式字符串。如果为 <c>null</c>，将使用默认格式。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回其字符串表示形式；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static string? ToString([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime, string? format)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.ToString(format);
            return result;
        }

        /// <summary>
        /// 移除可空 <see cref="DateTime"/> 的时间部分，仅保留日期部分。
        /// </summary>
        /// <param name="sourceDateTime">要移除时间部分的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回仅包含日期部分的 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? RemoveTime([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.RemoveTime();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 的前一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取前一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回前一天的 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? PreviousDay([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.PreviousDay();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 的下一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取下一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回下一天的 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? NextDay([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.NextDay();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 所在月份的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份第一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回该日期所在月份的第一天 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? CurrentMonthFirstDay([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.CurrentMonthFirstDay();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 所在日期的上一个月的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取上一个月第一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回该日期上一个月的第一天 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? GetFirstDayOfLastMonth([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.GetFirstDayOfLastMonth();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 所在日期的下一个月的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取下一个月第一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回该日期下一个月的第一天 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? GetFirstDayOfNextMonth([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.GetFirstDayOfNextMonth();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 所在月份的第一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份第一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回该日期所在月份的第一天 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? GetFirstDayOfMonth([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.GetFirstDayOfMonth();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 所在月份的最后一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份最后一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回该日期所在月份的最后一天 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? GetLastDayOfMonth([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.GetLastDayOfMonth();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 所在月份的倒数第二天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取倒数第二天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回该日期所在月份的倒数第二天 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? GetSecondDayToLastOfMonth([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.GetSecondDayToLastOfMonth();
            return result;
        }

        /// <summary>
        /// 获取可空 <see cref="DateTime"/> 所在月份的最后一天日期。
        /// </summary>
        /// <param name="sourceDateTime">要获取所在月份最后一天的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c>，则返回该日期所在月份的最后一天 <see cref="DateTime"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTime? CurrentMonthLastDay([NotNullIfNotNull(nameof(sourceDateTime))] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return null;
            }

            var result = sourceDateTime.Value.CurrentMonthLastDay();
            return result;
        }

        /// <summary>
        /// 判断可空 <see cref="DateTime"/> 是否为周末。
        /// </summary>
        /// <param name="sourceDateTime">要判断的可空 <see cref="DateTime"/>。</param>
        /// <returns>
        /// 如果 <paramref name="sourceDateTime"/> 不为 <c>null</c> 且为周六或周日，则返回 <c>true</c>；
        /// 否则返回 <c>false</c>。
        /// </returns>
        public static bool IsWeekend([NotNullWhen(true)] this DateTime? sourceDateTime)
        {
            if (sourceDateTime == null)
            {
                return false;
            }

            var result = sourceDateTime.Value.IsWeekend();
            return result;
        }
    }
}
