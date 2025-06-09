using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 将序列分割为指定数量的部分。
        /// </summary>
        /// <typeparam name="T">序列中元素的类型。</typeparam>
        /// <param name="this">要分割的序列。</param>
        /// <param name="parts">分割的部分数，必须大于 0。</param>
        /// <returns>分割后的序列集合，每个子序列为 <see cref="IEnumerable{T}"/>。</returns>
        /// <exception cref="ArgumentException">当 <paramref name="parts"/> 小于等于 0 时抛出。</exception>
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> @this, int parts)
        {
            if (parts <= 0)
            {
                throw new ArgumentException("Parts must be greater than 0.", nameof(parts));
            }

            int i = 0;
            var splits = from item in @this
                         group item by i++ / parts into part
                         select part.AsEnumerable();

            return splits;
        }
    }
}
