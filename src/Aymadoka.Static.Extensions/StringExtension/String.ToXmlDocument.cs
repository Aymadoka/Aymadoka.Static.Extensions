using System.Xml;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static XmlDocument ToXmlDocument(this string @this)
        {
            var doc = new XmlDocument();
            doc.LoadXml(@this);
            return doc;
        }
    }
}
