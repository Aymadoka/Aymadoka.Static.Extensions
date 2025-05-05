using Aymadoka.Static.EnumerableExtension;
using Aymadoka.Static.StringExtension;
using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        /// <summary>将 Base64 格式的字符串解码为字节数组</summary>
        /// <param name="this">要解码的 Base64 字符串</param>
        /// <returns>解码后的字节数组。</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 为 null 或空时抛出
        /// </exception>
        /// <exception cref="FormatException">
        /// 当 <paramref name="this"/> 不是有效的 Base64 字符串时抛出
        /// </exception>
        public static byte[] FromBase64(this string @this)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var bytes = Convert.FromBase64String(@this);
            return bytes;
        }
    }
}
