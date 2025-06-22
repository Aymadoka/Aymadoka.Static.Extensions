using System.Text.Json;

namespace Aymadoka.Static.SerializeExtension
{
    public class Serialize_FromJsonTests
    {
        private class TestClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        [Fact]
        public void FromJson_ValidJson_ReturnsObject()
        {
            var json = "{\"Name\":\"Alice\",\"Age\":30}";
            var result = json.FromJson<TestClass>();

            Assert.NotNull(result);
            Assert.Equal("Alice", result.Name);
            Assert.Equal(30, result.Age);
        }

        [Fact]
        public void FromJson_NullOrWhiteSpace_ReturnsNull()
        {
            string nullJson = null;
            string emptyJson = "";
            string whitespaceJson = "   ";

            Assert.Null(nullJson.FromJson<TestClass>());
            Assert.Null(emptyJson.FromJson<TestClass>());
            Assert.Null(whitespaceJson.FromJson<TestClass>());
        }

        [Fact]
        public void FromJson_InvalidJson_ReturnsNull()
        {
            var invalidJson = "{invalid json}";
            TestClass result = null;
            try
            {
                result = invalidJson.FromJson<TestClass>();
            }
            catch (JsonException)
            {
                // 期望抛出异常，返回 null
            }
            Assert.Null(result);
        }

        [Fact]
        public void FromJson_WithOptions_ReturnsObject()
        {
            var json = "{\"name\":\"Bob\",\"age\":25}";
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var result = json.FromJson<TestClass>(options);

            Assert.NotNull(result);
            Assert.Equal("Bob", result.Name);
            Assert.Equal(25, result.Age);
        }
    }
}
