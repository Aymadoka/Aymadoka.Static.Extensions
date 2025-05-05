using Aymadoka.Static.StringExtension;
using System;

namespace Aymadoka.Static.EnumExtension
{
    public static partial class EnumExtensions
    {
        /// <summary>将字符串解析为指定的枚举类型，支持忽略大小写</summary>
        /// <typeparam name="TEnum">目标枚举类型</typeparam>
        /// <param name="value">要解析的字符串值</param>
        /// <param name="ignoreCase">是否忽略大小写，默认为 <c>true</c></param>
        /// <returns>解析后的枚举值</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="value"/> 为 <c>null</c> 或空白字符串时抛出</exception>
        /// <exception cref="ArgumentException">当 <paramref name="value"/> 无法解析为指定的枚举类型时抛出</exception>
        public static TEnum ParseEnum<TEnum>(this string? value, bool ignoreCase = true) where TEnum : struct, Enum
        {
            if (value.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException(nameof(value));
            }

            return (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
        }
    }
}
