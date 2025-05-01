using System;
using System.Text;
using Aymadoka.Static.EnumerableExtension;
using Aymadoka.Static.StringExtension;

namespace Aymadoka.Static.Base64Extension
{
    public static class Base64Extensions
    {
        /// <summary>将字节数组编码为 Base64 格式的字符串</summary>
        /// <param name="this">要编码的字节数组</param>
        /// <returns>编码后的 Base64 字符串</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 为 null 或空时抛出
        /// </exception>
        public static string ToBase64(this byte[] @this)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var base64 = Convert.ToBase64String(@this);
            return base64;
        }

        /// <summary>将字符串编码为 Base64 格式的字符串</summary>
        /// <param name="this">要编码的字符串</param>
        /// <returns>编码后的 Base64 字符串</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 为 null 或空时抛出
        /// </exception>
        public static string ToBase64FromString(this string @this)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var bytes = Encoding.UTF8.GetBytes(@this);
            return bytes.ToBase64();
        }

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

        /// <summary>将 Base64 格式的字符串解码为普通字符串</summary>
        /// <param name="this">要解码的 Base64 字符串</param>
        /// <returns>解码后的普通字符串</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 为 null 或空时抛出
        /// </exception>
        /// <exception cref="FormatException">
        /// 当 <paramref name="this"/> 不是有效的 Base64 字符串时抛出
        /// </exception>
        public static string FromBase64ToString(this string @this)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var bytes = @this.FromBase64();
            var result = Encoding.UTF8.GetString(bytes);
            return result;
        }
    }
}
