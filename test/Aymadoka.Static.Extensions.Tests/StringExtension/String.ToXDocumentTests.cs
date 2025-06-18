using System.Xml.Linq;

namespace Aymadoka.Static.StringExtension
{
    public class String_ToXDocumentTests
    {
        [Fact]
        public void ToXDocument_ValidXml_ReturnsXDocument()
        {
            // Arrange
            string xml = "<root><child>value</child></root>";

            // Act
            XDocument doc = xml.ToXDocument();

            // Assert
            Assert.NotNull(doc);
            Assert.Equal("root", doc.Root.Name.LocalName);
            Assert.Equal("child", doc.Root.Element("child").Name.LocalName);
            Assert.Equal("value", doc.Root.Element("child").Value);
        }

        [Fact]
        public void ToXDocument_InvalidXml_ThrowsXmlException()
        {
            // Arrange
            string invalidXml = "<root><child></root>";

            // Act & Assert
            Assert.Throws<System.Xml.XmlException>(() => invalidXml.ToXDocument());
        }

        [Fact]
        public void ToXDocument_EmptyString_ThrowsXmlException()
        {
            // Arrange
            string emptyXml = "";

            // Act & Assert
            Assert.Throws<System.Xml.XmlException>(() => emptyXml.ToXDocument());
        }
    }
}
