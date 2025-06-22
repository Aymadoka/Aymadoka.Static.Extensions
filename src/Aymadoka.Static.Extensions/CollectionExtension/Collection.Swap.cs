using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// 将集合中所有等于 <paramref name="oldValue"/> 的元素替换为 <paramref name="newValue"/>。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要操作的集合。</param>
        /// <param name="oldValue">要被替换的旧值。</param>
        /// <param name="newValue">用于替换的新值。</param>
        public static void Swap<T>(this ICollection<T> @this, T oldValue, T newValue)
        {
            if (@this is IList<T> list)
            {
                // 针对 IList<T>，逐个查找并替换所有等于 oldValue 的元素
                var oldIndex = list.IndexOf(oldValue);
                while (oldIndex > 0)
                {
                    list.RemoveAt(oldIndex);
                    list.Insert(oldIndex, newValue);
                    oldIndex = list.IndexOf(oldValue);
                }
            }
            else
            {
                // 对于非 IList<T> 的集合，先生成替换后的集合，再清空原集合并重新添加
                var updatedCollection = @this.Select(item => EqualityComparer<T>.Default.Equals(item, oldValue) ? newValue : item).ToList();

                @this.Clear();
                foreach (var item in updatedCollection)
                {
                    @this.Add(item);
                }
            }
        }
    }
}
