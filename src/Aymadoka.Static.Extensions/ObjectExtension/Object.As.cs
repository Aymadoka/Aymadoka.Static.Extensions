using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 将对象强制转换为指定类型。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">要转换的对象。</param>
        /// <returns>转换后的对象。</returns>
        /// <exception cref="InvalidCastException">如果对象无法转换为指定类型时抛出。</exception>
        public static T As<T>(this object @this)
        {
            return (T)@this;
        }
    }
}
