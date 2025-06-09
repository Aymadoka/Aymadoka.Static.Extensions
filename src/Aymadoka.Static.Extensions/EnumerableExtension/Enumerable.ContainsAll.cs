using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 判断当前序列是否包含所有指定的元素。
        /// </summary>
        /// <typeparam name="T">序列中元素的类型。</typeparam>
        /// <param name="this">要检查的序列。</param>
        /// <param name="values">要检查是否包含的元素集合。</param>
        /// <returns>如果序列包含所有指定的元素，则为 true；否则为 false。</returns>
        public static bool ContainsAll<T>(this IEnumerable<T> @this, params T[] values)
        {
            return values.All(value => @this.Contains(value));
        }
    }
}
