using Aymadoka.Static.EnumerableExtension;
using Aymadoka.Static.StringExtension;
using System;
using System.Text;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
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

            var bytes = @this.FromBase64ToBytes();
            var result = Encoding.UTF8.GetString(bytes);
            return result;
        }
    }
}
