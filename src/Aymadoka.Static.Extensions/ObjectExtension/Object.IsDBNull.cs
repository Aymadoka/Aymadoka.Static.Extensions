using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断指定对象是否为 <see cref="DBNull"/>。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <param name="value">要判断的对象。</param>
        /// <returns>如果对象为 <see cref="DBNull"/>，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsDBNull<T>(this T value) where T : class
        {
            return Convert.IsDBNull(value);
        }
    }
}
