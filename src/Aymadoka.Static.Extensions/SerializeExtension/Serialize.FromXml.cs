using System.IO;
using System.Xml.Serialization;

namespace Aymadoka.Static.SerializeExtension
{
    public static partial class SerializeExtensions
    {
        /// <summary>将 XML 字符串反序列化为对象</summary>
        /// <typeparam name="T">目标对象的类型</typeparam>
        /// <param name="xml">XML 字符串</param>
        /// <returns>反序列化后的对象，如果 XML 字符串为空或无效，则返回 null</returns>
        public static T? FromXml<T>(this string? xml) where T : class
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                return null;
            }

            var serializer = new XmlSerializer(typeof(T));
            using var stringReader = new StringReader(xml);
            return serializer.Deserialize(stringReader) as T;
        }
    }
}
