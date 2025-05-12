using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 清除数组中的所有元素，将其设置为默认值。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要清除的数组。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        public static void ClearAll<T>(this T[] @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            Array.Clear(@this, 0, @this.Length);
        }
    }
}
