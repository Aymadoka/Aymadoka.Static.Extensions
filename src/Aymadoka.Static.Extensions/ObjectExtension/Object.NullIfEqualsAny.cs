using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 如果当前对象等于指定的任意一个值，则返回 null；否则返回当前对象本身。
        /// </summary>
        /// <typeparam name="T">引用类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="values">要比较的值集合。</param>
        /// <returns>如果等于任意一个值则为 null，否则为当前对象。</returns>
        public static T? NullIfEqualsAny<T>(this T @this, params T[] values) where T : class
        {
            if (Array.IndexOf(values, @this) != -1)
            {
                return null;
            }

            return @this;
        }
    }
}
