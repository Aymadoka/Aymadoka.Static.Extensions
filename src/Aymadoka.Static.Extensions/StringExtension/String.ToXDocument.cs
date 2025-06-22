using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将 XML 格式的字符串转换为 <see cref="XDocument"/> 对象。
        /// </summary>
        /// <param name="this">包含 XML 内容的字符串。</param>
        /// <returns>转换后的 <see cref="XDocument"/> 对象。</returns>
        /// <exception cref="System.Xml.XmlException">如果字符串不是有效的 XML，则抛出异常。</exception>
        public static XDocument ToXDocument(this string @this)
        {
            Encoding encoding = Activator.CreateInstance<UTF8Encoding>();
            using (var ms = new MemoryStream(encoding.GetBytes(@this)))
            {
                return XDocument.Load(ms);
            }
        }
    }
}
