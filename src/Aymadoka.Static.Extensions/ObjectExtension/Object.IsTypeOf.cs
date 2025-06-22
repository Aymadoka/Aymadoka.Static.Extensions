using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断当前对象的类型是否与指定的 <see cref="Type"/> 相同。
        /// </summary>
        /// <typeparam name="T">对象的类型。</typeparam>
        /// <param name="this">要判断类型的对象。</param>
        /// <param name="type">要比较的类型。</param>
        /// <returns>如果对象类型与指定类型相同，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsTypeOf<T>(this T @this, Type type) 
        {
            if (@this  == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var result = @this.GetType() == type;
            return result;
        }
    }
}
