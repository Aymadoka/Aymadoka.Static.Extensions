using System;
using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// 如果指定的 <paramref name="predicate"/> 对 <paramref name="value"/> 返回 true，则将 <paramref name="value"/> 添加到集合中。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要操作的集合。</param>
        /// <param name="predicate">用于判断是否添加元素的条件委托。</param>
        /// <param name="value">要添加的元素。</param>
        /// <returns>如果元素被添加到集合中，则返回 true；否则返回 false。</returns>
        public static bool AddIf<T>(this ICollection<T> @this, Func<T, bool> predicate, T value)
        {
            if (predicate(value))
            {
                @this.Add(value);
                return true;
            }

            return false;
        }
    }
}
