using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断当前对象是否不在指定的值集合中。
        /// </summary>
        /// <typeparam name="T">对象类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="values">要比较的值集合。</param>
        /// <returns>如果对象不在集合中，则返回 true；否则返回 false。</returns>
        public static bool NotIn<T>(this T @this, params T[] values)
        {
            return Array.IndexOf(values, @this) == -1;
        }
    }
}
