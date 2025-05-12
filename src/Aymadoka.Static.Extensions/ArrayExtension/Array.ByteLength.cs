using System;
using System.Runtime.CompilerServices;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 获取指定数组的字节长度。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要获取字节长度的数组。</param>
        /// <returns>数组的字节长度。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        public static int ByteLength<T>(this T[] @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }
            else if (@this.Length == 0)
            {
                return 0;
            }

            var elementType = @this.GetType().GetElementType();

            // 处理基元类型数组
            if (elementType.IsPrimitive)
            {
                var result = Buffer.ByteLength(@this);
                return result;
            }
            else if (elementType == typeof(DateTime))
            {
                var result = @this.Length * Unsafe.SizeOf<DateTime>();
                return result;
            }

            // 其他类型抛出异常
            throw new ArgumentException("Object must be an array of primitives or DateTime.", nameof(@this));
        }
    }
}
