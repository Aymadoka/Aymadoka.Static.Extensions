using System;
using System.Reflection;

namespace Aymadoka.Static.EnumExtension
{
    public static partial class EnumExtensions
    {
        /// <summary>检查指定的枚举类型是否带有 <see cref="FlagsAttribute"/> 标记</summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <param name="value">要检查的枚举值</param>
        /// <returns>如果枚举类型带有 <see cref="FlagsAttribute"/> 标记，则返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool HasFlagsAttribute<TEnum>(this TEnum value) where TEnum : Enum
        {
            return typeof(TEnum).GetCustomAttribute<FlagsAttribute>() != null;
        }
    }
}
