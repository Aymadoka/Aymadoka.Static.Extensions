using Aymadoka.Static.EnumerableExtension;
using Aymadoka.Static.StringExtension;
using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        /// <summary>
        /// 将字节数组转换为Base64字符串。
        /// </summary>
        /// <param name="this">要转换的字节数组。</param>
        /// <returns>Base64编码的字符串。</returns>
        /// <exception cref="ArgumentNullException">当字节数组为null或空时抛出。</exception>
        public static string ToBase64FromBytes(this byte[] @this)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var base64 = Convert.ToBase64String(@this);
            return base64;
        }

        /// <summary>
        /// 使用指定的格式选项将字节数组转换为Base64字符串。
        /// </summary>
        /// <param name="this">要转换的字节数组。</param>
        /// <param name="options">Base64格式化选项。</param>
        /// <returns>Base64编码的字符串。</returns>
        /// <exception cref="ArgumentNullException">当字节数组为null或空时抛出。</exception>
        public static string ToBase64FromBytes(this byte[] @this, Base64FormattingOptions options)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return Convert.ToBase64String(@this, options);
        }

        /// <summary>
        /// 将字节数组的指定范围转换为Base64字符串。
        /// </summary>
        /// <param name="this">要转换的字节数组。</param>
        /// <param name="offset">起始偏移量。</param>
        /// <param name="length">要转换的字节数。</param>
        /// <returns>Base64编码的字符串。</returns>
        /// <exception cref="ArgumentNullException">当字节数组为null或空时抛出。</exception>
        public static string ToBase64FromBytes(this byte[] @this, int offset, int length)
        {
            if (@this.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return Convert.ToBase64String(@this, offset, length);
        }

        /// <summary>
        /// 使用指定的格式选项将字节数组的指定范围转换为Base64字符串。
        /// </summary>
        /// <param name="this">要转换的字节数组。</param>
        /// <param name="offset">起始偏移量。</param>
        /// <param name="length">要转换的字节数。</param>
        /// <param name="options">Base64格式化选项。</param>
        /// <returns>Base64编码的字符串。</returns>
        /// <exception cref="ArgumentNullException">当字节数组为null或空时抛出。</exception>
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
