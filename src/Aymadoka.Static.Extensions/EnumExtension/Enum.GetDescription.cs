using System;
using System.ComponentModel;
using System.Linq;

namespace Aymadoka.Static.EnumExtension
{
    public static partial class EnumExtensions
    {
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
            var attribute = field?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                             .OfType<DescriptionAttribute>()
                             .FirstOrDefault();

            return attribute?.Description ?? value.ToString();
        }
    }
}
