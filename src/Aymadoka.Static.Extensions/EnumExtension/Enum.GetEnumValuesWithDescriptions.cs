using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumExtension
{
    public static partial class EnumExtensions
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
        public static List<(TEnum Value, string Description)> GetEnumValuesWithDescriptions<TEnum>(this TEnum value) where TEnum : Enum
        {
            return GetEnumValuesWithDescriptions<TEnum>();
        }
    }
}
