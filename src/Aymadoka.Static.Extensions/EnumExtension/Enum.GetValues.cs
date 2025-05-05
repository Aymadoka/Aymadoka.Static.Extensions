using System;

namespace Aymadoka.Static.EnumExtension
{
    public static partial class EnumExtensions
    {
        /// <summary>获取所有枚举值的数组</summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <returns>枚举值数组</returns>
        public static TEnum[] GetValues<TEnum>() where TEnum : Enum
        {
            return (TEnum[])Enum.GetValues(typeof(TEnum));
        }
    }
}
