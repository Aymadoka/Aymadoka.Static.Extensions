using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断当前对象是否为枚举类型。
        /// </summary>
        /// <typeparam name="T">对象类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <returns>如果对象为枚举类型则返回 true，否则返回 false。</returns>
        public static bool IsEnum<T>(this T @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var result = @this.GetType().IsEnum;
            return result;
        }
    }
}
