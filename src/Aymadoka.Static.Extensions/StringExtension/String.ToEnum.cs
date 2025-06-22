using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串转换为指定的枚举类型。
        /// </summary>
        /// <typeparam name="T">目标枚举类型。</typeparam>
        /// <param name="this">要转换的字符串。</param>
        /// <returns>转换后的枚举值。</returns>
        /// <exception cref="ArgumentException">如果字符串不能转换为指定的枚举类型时抛出。</exception>
        public static T ToEnum<T>(this string @this)
        {
            Type enumType = typeof(T);
            return (T)Enum.Parse(enumType, @this);
        }
    }
}
