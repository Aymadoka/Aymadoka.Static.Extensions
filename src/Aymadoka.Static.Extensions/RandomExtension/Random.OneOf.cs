using System;

namespace Aymadoka.Static.RandomExtension
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// 从提供的值数组中随机选择一个元素并返回。
        /// </summary>
        /// <typeparam name="T">元素的类型。</typeparam>
        /// <param name="this">用于生成随机数的 <see cref="Random"/> 实例。</param>
        /// <param name="values">要选择的元素数组。</param>
        /// <returns>从 <paramref name="values"/> 中随机选择的一个元素。</returns>
        public static T OneOf<T>(this Random @this, params T[] values)
        {
            return values[@this.Next(values.Length)];
        }
    }
}
