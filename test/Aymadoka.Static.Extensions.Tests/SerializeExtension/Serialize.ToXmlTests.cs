namespace Aymadoka.Static.SerializeExtension
{
    public class Serialize_ToXmlTests
    {
        private class TestClass
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }

        [Fact]
        public void ToXml_WithNullObject_ReturnsNull()
        {
            // Arrange
            TestClass? obj = null;

            // Act
            var xml = obj.ToXml();

            // Assert
            Assert.Null(xml);
        }
    }
}
