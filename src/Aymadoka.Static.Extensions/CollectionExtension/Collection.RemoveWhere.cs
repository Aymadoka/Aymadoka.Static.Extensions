using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// 从集合中移除所有满足指定谓词的元素。
        /// </summary>
        /// <typeparam name="T">集合中元素的类型。</typeparam>
        /// <param name="this">要操作的集合。</param>
        /// <param name="predicate">用于测试每个元素是否应被移除的谓词。</param>
        public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
        {
            var list = @this.Where(predicate).ToList();

            foreach (T item in list)
            {
                @this.Remove(item);
            }
        }
    }
}
