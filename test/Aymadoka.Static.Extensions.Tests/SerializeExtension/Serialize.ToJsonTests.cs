using System.Text.Json;

namespace Aymadoka.Static.SerializeExtension
{
    public class Serialize_ToJsonTests
    {
        private class TestClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void ToJson_ReturnsNull_WhenDataIsNull()
        {
            TestClass? obj = null;
            var result = obj.ToJson();
            Assert.Null(result);
        }

        [Fact]
        public void ToJson_SerializesObjectCorrectly()
        {
            var obj = new TestClass { Id = 1, Name = "Test" };
            var json = obj.ToJson();
            Assert.Contains("\"Id\":1", json);
            Assert.Contains("\"Name\":\"Test\"", json);
        }

        [Fact]
        public void ToJson_UsesProvidedOptions()
        {
            var obj = new TestClass { Id = 2, Name = "Test2" };
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = obj.ToJson(options);
            Assert.Contains("\"id\":2", json);
            Assert.Contains("\"name\":\"Test2\"", json);
        }
    }
}
