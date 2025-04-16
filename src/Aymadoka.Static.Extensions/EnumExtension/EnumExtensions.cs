using Aymadoka.Static.StringExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Aymadoka.Static.EnumExtension
{
    public static class EnumExtensions
    {
        /// <summary>获取枚举类型的所有值及其描述</summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <returns>包含枚举值及其描述的列表</returns>
        public static List<(TEnum Value, string Description)> GetEnumValuesWithDescriptions<TEnum>() where TEnum : Enum
        {
            var enumerable = from p in typeof(TEnum).GetFields()
                             where p.IsStatic
                             let item = (TEnum)p.GetValue(null)
                             select (item, item.GetDescription());

            var items = enumerable.ToList();
            return items;
        }

        /// <summary>获取枚举类型的所有值及其描述</summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <param name="value">枚举值（未使用，仅用于调用扩展方法）</param>
        /// <returns>包含枚举值及其描述的列表</returns>
        public static List<(TEnum value, string description)> GetEnumValuesWithDescriptions<TEnum>(this TEnum value) where TEnum : Enum
        {
            return GetEnumValuesWithDescriptions<TEnum>();
        }

        /// <summary>获取枚举值的描述</summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <param name="value">要获取描述的枚举值</param>
        /// <returns>则返回其描述</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="value"/> 为 null 时抛出</exception>
        public static string GetDescription<TEnum>(this TEnum value) where TEnum : Enum
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var field = value.GetType().GetField(value.ToString());
            var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                 .OfType<DescriptionAttribute>()
                                 .FirstOrDefault();

            return attribute?.Description ?? value.ToString();
        }

        /// <summary>检查指定的枚举值是否在枚举类型中定义</summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <param name="value">要检查的枚举值</param>
        /// <remarks>
        /// 此方法使用 <see cref="Enum.IsDefined(Type, object)"/> 方法来检查枚举值是否在指定的枚举类型中定义
        /// </remarks>
        /// <example>
        /// 以下是使用 <c>IsDefined</c> 方法的示例：
        /// <code>
        /// enum TestEnum { Value1, Value2 }
        /// bool isDefined = TestEnum.Value1.IsDefined(); // 返回 true
        /// bool isNotDefined = ((TestEnum)999).IsDefined(); // 返回 false
        /// </code>
        /// </example>
        public static bool IsDefined<TEnum>(this TEnum value) where TEnum : Enum
        {
            return Enum.IsDefined(typeof(TEnum), value);
        }

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

        /// <summary>获取所有枚举值的数组</summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <returns>枚举值数组</returns>
        public static TEnum[] GetValues<TEnum>() where TEnum : Enum
        {
            return (TEnum[])Enum.GetValues(typeof(TEnum));
        }

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
