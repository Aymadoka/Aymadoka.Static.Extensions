using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Aymadok.Static.EnumExtension
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

        /// <summary>
        /// 检查枚举值是否定义在指定的枚举类型中。
        /// </summary>
        public static bool IsDefined<TEnum>(this TEnum value) where TEnum : Enum
        {
            return Enum.IsDefined(typeof(TEnum), value);
        }

        /// <summary>
        /// 将字符串解析为指定的枚举类型，支持忽略大小写。
        /// </summary>
        public static TEnum ParseEnum<TEnum>(this string value, bool ignoreCase = true) where TEnum : struct, Enum
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            return (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
        }

        /// <summary>
        /// 获取所有枚举值的数组。
        /// </summary>
        public static TEnum[] GetValues<TEnum>() where TEnum : Enum
        {
            return (TEnum[])Enum.GetValues(typeof(TEnum));
        }

        /// <summary>
        /// 检查枚举值是否有 [Flags] 属性标记。
        /// </summary>
        public static bool HasFlagsAttribute<TEnum>(this TEnum value) where TEnum : Enum
        {
            return typeof(TEnum).GetCustomAttribute<FlagsAttribute>() != null;
        }

        /// <summary>
        /// 检查一个标志是否被设置在 [Flags] 枚举中。
        /// </summary>
        public static bool HasFlag<TEnum>(this TEnum value, TEnum flag) where TEnum : Enum
        {
            if (!HasFlagsAttribute(value))
            {
                throw new InvalidOperationException("此方法仅适用于带有 [Flags] 属性的枚举类型");
            }

            return (Convert.ToInt64(value) & Convert.ToInt64(flag)) == Convert.ToInt64(flag);
        }
    }
}
