using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 如果指定的谓词为 true，则返回 null；否则返回原对象。
        /// </summary>
        /// <typeparam name="T">引用类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="predicate">用于判断对象是否应返回 null 的谓词。</param>
        /// <returns>如果谓词为 true，则为 null；否则为原对象。</returns>
        public static T? NullIf<T>(this T @this, Func<T, bool> predicate) where T : class
        {
            if (predicate(@this))
            {
                return null;
            }

            return @this;
        }
    }
}
