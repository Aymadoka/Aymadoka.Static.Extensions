using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 判断指定索引是否在一维数组的有效范围内。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要检查的数组。</param>
        /// <param name="index">要检查的索引。</param>
        /// <returns>
        /// 如果 <paramref name="index"/> 在数组的有效范围内（大于等于 0 且小于数组长度），则返回 <c>true</c>；否则返回 <c>false</c>。
        /// </returns>
        /// <exception cref="NullReferenceException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        public static bool WithinIndex<T>(this T[] @this, int index)
        {
            return index >= 0 && index < @this.Length;
        }

        /// <summary>
        /// 判断指定索引是否在一维数组指定维度的有效范围内。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要检查的数组。</param>
        /// <param name="index">要检查的索引。</param>
        /// <param name="dimension">要检查的维度（对于一维数组应为 0）。</param>
        /// <returns>
        /// 如果 <paramref name="index"/> 在指定维度的有效范围内（大于等于该维度的下界且小于等于上界），则返回 <c>true</c>；否则返回 <c>false</c>。
        /// </returns>
        /// <exception cref="NullReferenceException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        /// <exception cref="IndexOutOfRangeException">当 <paramref name="dimension"/> 小于 0 或大于等于数组的维数时抛出。</exception>
        public static bool WithinIndex<T>(this T[] @this, int index, int dimension)
        {
            return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
        }
    }
}
