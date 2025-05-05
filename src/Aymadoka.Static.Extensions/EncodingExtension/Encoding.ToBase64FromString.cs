using Aymadoka.Static.EnumerableExtension;
using Aymadoka.Static.StringExtension;
using System;
using System.Text;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
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
            return bytes.ToBase64String();
        }
    }
}
