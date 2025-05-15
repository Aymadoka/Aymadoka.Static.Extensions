using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 调整字节数组的大小到指定的新长度。
        /// </summary>
        /// <param name="this">要调整大小的字节数组。</param>
        /// <param name="newSize">新数组的长度。</param>
        /// <returns>调整大小后的新字节数组。</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 当 <paramref name="newSize"/> 小于零时抛出。
        /// </exception>
        public static byte[] Resize(this byte[] @this, int newSize)
        {
            Array.Resize(ref @this, newSize);
            return @this;
        }
    }
}
