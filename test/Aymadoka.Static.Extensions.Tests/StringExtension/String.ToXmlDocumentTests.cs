using System.Xml;

namespace Aymadoka.Static.StringExtension
{
    public class String_ToXmlDocumentTests
    {
        [Fact]
        public void ToXmlDocument_ValidXml_ReturnsXmlDocument()
        {
            // Arrange
            string xml = "<root><child>value</child></root>";

            // Act
            XmlDocument doc = xml.ToXmlDocument();

            // Assert
            Assert.NotNull(doc);
            Assert.Equal("root", doc.DocumentElement.Name);
            Assert.Equal("child", doc.DocumentElement.FirstChild.Name);
            Assert.Equal("value", doc.DocumentElement.FirstChild.InnerText);
        }

        [Fact]
        public void ToXmlDocument_InvalidXml_ThrowsXmlException()
        {
            // Arrange
            string invalidXml = "<root><child></root>";

            // Act & Assert
            Assert.Throws<XmlException>(() => invalidXml.ToXmlDocument());
        }

        [Fact]
        public void ToXmlDocument_EmptyString_ThrowsXmlException()
        {
            // Arrange
            string emptyXml = "";

            // Act & Assert
            Assert.Throws<XmlException>(() => emptyXml.ToXmlDocument());
        }

        [Fact]
        public void ToXmlDocument_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string nullXml = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => nullXml.ToXmlDocument());
        }
    }
}
