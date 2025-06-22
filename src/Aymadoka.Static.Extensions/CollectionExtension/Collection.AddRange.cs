using System;
using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// 向 <see cref="ICollection{T}"/> 扩展方法，批量添加元素。
        /// </summary>
        /// <typeparam name="T">集合元素类型。</typeparam>
        /// <param name="this">目标集合。</param>
        /// <param name="values">要添加的元素数组。</param>
        public static void AddRange<T>(this ICollection<T> @this, params T[] values)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            foreach (T value in values)
            {
                @this.Add(value);
            }
        }
    }
}
