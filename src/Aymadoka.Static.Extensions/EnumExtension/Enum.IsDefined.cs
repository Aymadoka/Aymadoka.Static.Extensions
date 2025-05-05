using System;

namespace Aymadoka.Static.EnumExtension
{
    public static partial class EnumExtensions
    {
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
    }
}
