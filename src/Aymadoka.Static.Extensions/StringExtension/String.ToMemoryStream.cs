using System;
using System.IO;
using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将当前字符串使用 ASCII 编码转换为 <see cref="MemoryStream"/>。
        /// </summary>
        /// <param name="this">要转换的字符串。</param>
        /// <returns>包含字符串内容的 <see cref="MemoryStream"/> 实例。</returns>
        public static Stream ToMemoryStream(this string @this)
        {
            Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
            return new MemoryStream(encoding.GetBytes(@this));
        }
    }
}
