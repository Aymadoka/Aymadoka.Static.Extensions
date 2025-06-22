using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 判断当前序列是否包含指定的任意一个元素。
        /// </summary>
        /// <typeparam name="T">序列元素的类型。</typeparam>
        /// <param name="this">要搜索的序列。</param>
        /// <param name="values">要检查是否存在于序列中的元素集合。</param>
        /// <returns>如果序列中包含任意一个指定元素，则返回 true；否则返回 false。</returns>
        public static bool ContainsAny<T>(this IEnumerable<T> @this, params T[] values)
        {
            return values.Any(value => @this.Contains(value));
        }
    }
}
