using System.Xml;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串转换为 <see cref="XmlDocument"/> 对象。
        /// </summary>
        /// <param name="this">包含 XML 内容的字符串。</param>
        /// <returns>转换后的 <see cref="XmlDocument"/> 对象。</returns>
        /// <exception cref="XmlException">如果字符串不是有效的 XML，则抛出异常。</exception>
        public static XmlDocument ToXmlDocument(this string @this)
        {
            var doc = new XmlDocument();
            doc.LoadXml(@this);
            return doc;
        }
    }
}
