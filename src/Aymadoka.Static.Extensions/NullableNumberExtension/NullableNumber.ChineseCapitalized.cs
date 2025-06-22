using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        // static string? ChineseCapitalized<T>(this T? source) where T : struct, IFloatingPoint<T>

        /// <summary>
        /// 将可空 <see cref="byte"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="byte"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this byte? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="short"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="short"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this short? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="ushort"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="ushort"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this ushort? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="int"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="int"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this int? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="uint"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="uint"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this uint? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="long"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="long"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this long? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="ulong"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="ulong"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this ulong? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="float"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="float"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this float? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="double"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="double"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this double? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }

        /// <summary>
        /// 将可空 <see cref="decimal"/> 数值转换为中文大写金额字符串。
        /// </summary>
        /// <param name="this">可空 <see cref="decimal"/> 数值。</param>
        /// <returns>中文大写金额字符串，若为 null 则返回 null。</returns>
        public static string? ChineseCapitalized(this decimal? @this)
        {
            if (!@this.HasValue)
            {
                return null;
            }

            var result = @this.Value.ChineseCapitalized();
            return result;
        }
    }
}
