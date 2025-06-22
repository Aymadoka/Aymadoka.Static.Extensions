using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断当前对象的类型是否为类类型。
        /// </summary>
        /// <typeparam name="T">对象类型。</typeparam>
        /// <param name="this">要判断的对象实例。</param>
        /// <returns>如果对象类型为类类型，则返回 true；否则返回 false。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        public static bool IsClass<T>(this T @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var result = @this.GetType().IsClass;
            return result;
        }
    }
}
