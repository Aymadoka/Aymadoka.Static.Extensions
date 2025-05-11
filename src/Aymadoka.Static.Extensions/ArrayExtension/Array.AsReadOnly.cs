using System;
using System.Collections.ObjectModel;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 将数组包装为只读集合。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要转换为只读集合的数组。</param>
        /// <returns>一个只读集合，表示原始数组的包装。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] @this)
        {
            // 检查输入数组是否为 null，避免潜在的空引用异常
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this), "The input array cannot be empty.");
            }

            // 使用内置方法将数组转换为只读集合
            return Array.AsReadOnly(@this);
        }
    }
}
