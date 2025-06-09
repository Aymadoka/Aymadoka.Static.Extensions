using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        /// <summary>
        /// 将字节数组转换为 UTF-8 编码的字符串。
        /// </summary>
        /// <param name="this">要转换的字节数组。</param>
        /// <returns>转换后的字符串。</returns>
        /// <exception cref="ArgumentNullException">当字节数组为 null 时抛出。</exception>
        public static string FromBytesToString(this byte[] @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            string result = System.Text.Encoding.UTF8.GetString(@this);
            return result;
        }
    }
}
