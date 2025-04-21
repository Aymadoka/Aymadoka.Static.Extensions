using System.Text.Json;

namespace Aymadoka.Static.JsonExtension
{
    public class JsonExtensionsTest
    {
        public class TestObject
        {
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
            public List<string>? Tags { get; set; }
            public NestedObject? Nested { get; set; }
        }

        public class NestedObject
        {
            public string Description { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
        }

        [Theory]
        [InlineData(null, null)] // 空对象
        public void ToJson_ShouldReturnNull_ForNullObject(TestObject? obj, string? expected)
        {
            Assert.Equal(expected, obj.ToJson());
        }

        [Fact]
        public void ToJson_ShouldSerializeSimpleObject_ToJsonString()
        {
            // Arrange
            var obj = new TestObject { Name = "Alice", Age = 25 };
            var expectedJson = "{\"Name\":\"Alice\",\"Age\":25,\"Tags\":null,\"Nested\":null}";

            // Act
            var json = obj.ToJson();

            // Assert
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void ToJson_ShouldSerializeObjectWithNestedObject()
        {
            // Arrange
            var obj = new TestObject
            {
                Name = "Alice",
                Age = 25,
                Nested = new NestedObject
                {
                    Description = "Nested description",
                    CreatedAt = new DateTime(2025, 4, 20)
                }
            };
            var expectedJson = "{\"Name\":\"Alice\",\"Age\":25,\"Tags\":null,\"Nested\":{\"Description\":\"Nested description\",\"CreatedAt\":\"2025-04-20T00:00:00\"}}";

            // Act
            var json = obj.ToJson();

            // Assert
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void ToJson_ShouldSerializeObjectWithCollection()
        {
            // Arrange
            var obj = new TestObject
            {
                Name = "Alice",
                Age = 25,
                Tags = new List<string> { "Tag1", "Tag2", "Tag3" }
            };
            var expectedJson = "{\"Name\":\"Alice\",\"Age\":25,\"Tags\":[\"Tag1\",\"Tag2\",\"Tag3\"],\"Nested\":null}";

            // Act
            var json = obj.ToJson();

            // Assert
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void ToJson_ShouldUseCustomOptions_WhenProvided()
        {
            // Arrange
            var obj = new TestObject { Name = "Alice", Age = 25 };
            var options = new JsonSerializerOptions { WriteIndented = true };

            // Act
            var json = obj.ToJson(options);

            // Assert
            Assert.Contains("\n", json); // 验证是否使用了缩进格式
        }

        [Fact]
        public void ToJson_ShouldHandleEmptyObject()
        {
            // Arrange
            var obj = new TestObject();

            // Act
            var json = obj.ToJson();

            // Assert
            Assert.Equal("{\"Name\":\"\",\"Age\":0,\"Tags\":null,\"Nested\":null}", json);
        }

        [Fact]
        public void ToJson_ShouldHandleObjectWithNullProperties()
        {
            // Arrange
            var obj = new TestObject
            {
                Name = "Alice",
                Age = 25,
                Tags = null,
                Nested = null
            };

            // Act
            var json = obj.ToJson();

            // Assert
            Assert.Equal("{\"Name\":\"Alice\",\"Age\":25,\"Tags\":null,\"Nested\":null}", json);
        }

    }
}
