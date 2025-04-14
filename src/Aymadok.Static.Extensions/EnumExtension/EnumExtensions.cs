using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Aymadok.Static.EnumExtension
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                 .FirstOrDefault() as DescriptionAttribute;
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
        /// 获取所有枚举值及其描述的键值对。
        /// </summary>
        public static (TEnum Value, string Description)[] GetValuesWithDescriptions<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                       .Cast<TEnum>()
                       .Select(e => (Value: e, Description: e.GetDescription()))
                       .ToArray();
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
                throw new InvalidOperationException("此方法仅适用于带有 [Flags] 属性的枚举类型");

            return (Convert.ToInt64(value) & Convert.ToInt64(flag)) == Convert.ToInt64(flag);
        }
    }
}
