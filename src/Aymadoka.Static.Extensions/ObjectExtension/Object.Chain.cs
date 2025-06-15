using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 对对象执行指定操作，并返回该对象本身，实现链式调用。
        /// </summary>
        /// <typeparam name="T">对象的类型。</typeparam>
        /// <param name="this">要操作的对象。</param>
        /// <param name="action">要对对象执行的操作。</param>
        /// <returns>操作后的原对象。</returns>
        public static T Chain<T>(this T @this, Action<T> action)
        {
            action(@this);

            return @this;
        }
    }
}
