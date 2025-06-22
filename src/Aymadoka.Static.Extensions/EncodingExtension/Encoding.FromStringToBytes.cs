using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        /// <summary>
        /// 将字符串转换为 UTF-8 编码的字节数组。
        /// </summary>
        /// <param name="this">要转换的字符串。</param>
        /// <returns>UTF-8 编码的字节数组。</returns>
        /// <exception cref="ArgumentNullException">当字符串为 null 时抛出。</exception>
        public static byte[] FromStringToBytes(this string @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(@this);
            return bytes;
        }
    }
}
