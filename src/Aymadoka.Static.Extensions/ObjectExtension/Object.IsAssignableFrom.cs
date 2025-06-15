using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断当前对象的类型是否可以从指定类型 <typeparamref name="T"/> 赋值。
        /// </summary>
        /// <typeparam name="T">要检查的目标类型。</typeparam>
        /// <param name="this">当前对象实例。</param>
        /// <returns>如果当前对象的类型可以从 <typeparamref name="T"/> 赋值，则为 true；否则为 false。</returns>
        public static bool IsAssignableFrom<T>(this object @this)
        {
            Type type = @this.GetType();
            return type.IsAssignableFrom(typeof(T));
        }

        /// <summary>
        /// 判断当前对象的类型是否可以从指定的 <paramref name="targetType"/> 赋值。
        /// </summary>
        /// <param name="this">当前对象实例。</param>
        /// <param name="targetType">要检查的目标类型。</param>
        /// <returns>如果当前对象的类型可以从 <paramref name="targetType"/> 赋值，则为 true；否则为 false。</returns>
        public static bool IsAssignableFrom(this object @this, Type targetType)
        {
            Type type = @this.GetType();
            return type.IsAssignableFrom(targetType);
        }
    }
}
