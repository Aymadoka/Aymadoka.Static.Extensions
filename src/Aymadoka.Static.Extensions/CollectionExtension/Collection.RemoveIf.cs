using System;
using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// 如果指定的 <paramref name="value"/> 满足 <paramref name="predicate"/> 条件，则从集合中移除该元素。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要操作的集合。</param>
        /// <param name="value">要判断并可能移除的元素。</param>
        /// <param name="predicate">用于判断元素是否应被移除的条件委托。</param>
        public static void RemoveIf<T>(this ICollection<T> @this, T value, Func<T, bool> predicate)
        {
            if (predicate(value))
            {
                @this.Remove(value);
            }
        }
    }
}
