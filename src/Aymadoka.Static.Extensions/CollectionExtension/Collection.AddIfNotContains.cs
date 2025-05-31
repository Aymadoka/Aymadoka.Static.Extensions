using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// 如果集合中不包含指定的值，则将其添加到集合中。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要操作的集合。</param>
        /// <param name="value">要添加的值。</param>
        /// <returns>如果成功添加了值，则返回 true；如果集合已包含该值，则返回 false。</returns>
        public static bool AddIfNotContains<T>(this ICollection<T> @this, T value)
        {
            if (!@this.Contains(value))
            {
                @this.Add(value);
                return true;
            }

            return false;
        }
    }
}
