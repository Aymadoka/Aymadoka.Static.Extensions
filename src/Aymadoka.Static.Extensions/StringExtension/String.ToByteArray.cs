using System;
using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 使用UTF8编码将字符串转换为字节数组。
        /// </summary>
        /// <param name="this">要转换的字符串。</param>
        /// <returns>转换后的字节数组。</returns>
        public static byte[] ToByteArray(this string @this)
        {
            var encoding = Activator.CreateInstance<UTF8Encoding>();
            return encoding.GetBytes(@this);
        }
    }
}
