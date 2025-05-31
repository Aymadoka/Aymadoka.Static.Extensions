using System;
using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// 向集合中添加满足指定条件的元素。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要添加元素的集合。</param>
        /// <param name="predicate">用于判断元素是否应被添加的条件。</param>
        /// <param name="values">要判断并可能添加到集合的元素。</param>
        public static void AddRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (T value in values)
            {
                if (predicate(value))
                {
                    @this.Add(value);
                }
            }
        }
    }
}
