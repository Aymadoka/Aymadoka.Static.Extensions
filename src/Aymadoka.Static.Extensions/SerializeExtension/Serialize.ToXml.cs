using System.IO;
using System.Xml.Serialization;

namespace Aymadoka.Static.SerializeExtension
{
    public static partial class SerializeExtensions
    {
        /// <summary>将对象序列化为 XML 字符串</summary>
        /// <typeparam name="T">对象的类型</typeparam>
        /// <param name="data">要序列化的对象</param>
        /// <returns>XML 字符串，如果对象为 null，则返回 null</returns>
        public static string? ToXml<T>(this T? data) where T : class
        {
            if (data == null)
            {
                return null;
            }

            var serializer = new XmlSerializer(typeof(T));
            using var stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, data);
            return stringWriter.ToString();
        }
    }
}
