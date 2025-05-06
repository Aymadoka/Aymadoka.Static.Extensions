using Aymadoka.Static.EnumerableExtension;
using Aymadoka.Static.StringExtension;
using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        /// <summary>将字节数组编码为 Base64 格式的字符串</summary>
        /// <param name="this">要编码的字节数组</param>
        /// <returns>编码后的 Base64 字符串</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 为 null 或空时抛出
        /// </exception>
        public static string ToBase64FromBytes(this byte[] @this)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var base64 = Convert.ToBase64String(@this);
            return base64;
        }

        public static string ToBase64FromBytes(this byte[] @this, Base64FormattingOptions options)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return Convert.ToBase64String(@this, options);
        }

        public static string ToBase64FromBytes(this byte[] @this, int offset, int length)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return Convert.ToBase64String(@this, offset, length);
        }

        public static string ToBase64FromBytes(this Byte[] @this, int offset, int length, Base64FormattingOptions options)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return Convert.ToBase64String(@this, offset, length, options);
        }
    }
}
