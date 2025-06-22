using System.Xml.Serialization;

namespace Aymadoka.Static.SerializeExtension
{
    public class Serialize_FromXmlTests
    {
        [XmlRoot("Person")]
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        [Fact]
        public void FromXml_ReturnsObject_WhenValidXml()
        {
            string xml = "<Person><Name>Tom</Name><Age>30</Age></Person>";
            var person = xml.FromXml<Person>();
            Assert.NotNull(person);
            Assert.Equal("Tom", person.Name);
            Assert.Equal(30, person.Age);
        }

        [Fact]
        public void FromXml_ReturnsNull_WhenXmlIsNull()
        {
            string xml = null;
            var result = xml.FromXml<Person>();
            Assert.Null(result);
        }

        [Fact]
        public void FromXml_ReturnsNull_WhenXmlIsEmpty()
        {
            string xml = "";
            var result = xml.FromXml<Person>();
            Assert.Null(result);
        }

        [Fact]
        public void FromXml_ReturnsNull_WhenXmlIsWhitespace()
        {
            string xml = "   ";
            var result = xml.FromXml<Person>();
            Assert.Null(result);
        }
    }
}
