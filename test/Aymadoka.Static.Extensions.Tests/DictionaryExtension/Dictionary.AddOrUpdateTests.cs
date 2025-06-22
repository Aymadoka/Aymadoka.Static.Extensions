namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_AddOrUpdateTests
    {
        [Fact]
        public void AddOrUpdate_AddsValue_WhenKeyDoesNotExist()
        {
            var dict = new Dictionary<string, int>();
            var result = dict.AddOrUpdate("a", 1);
            Assert.Equal(1, result);
            Assert.True(dict.ContainsKey("a"));
            Assert.Equal(1, dict["a"]);
        }

        [Fact]
        public void AddOrUpdate_UpdatesValue_WhenKeyExists()
        {
            var dict = new Dictionary<string, int> { { "a", 1 } };
            var result = dict.AddOrUpdate("a", 2);
            Assert.Equal(2, result);
            Assert.Equal(2, dict["a"]);
        }

        [Fact]
        public void AddOrUpdate_AddsValue_WithAddValue_WhenKeyDoesNotExist()
        {
            var dict = new Dictionary<string, int>();
            var result = dict.AddOrUpdate("b", 5, (k, v) => v + 10);
            Assert.Equal(5, result);
            Assert.Equal(5, dict["b"]);
        }

        [Fact]
        public void AddOrUpdate_UpdatesValue_WithUpdateValueFactory_WhenKeyExists()
        {
            var dict = new Dictionary<string, int> { { "b", 3 } };
            var result = dict.AddOrUpdate("b", 5, (k, v) => v + 10);
            Assert.Equal(13, result);
            Assert.Equal(13, dict["b"]);
        }

        [Fact]
        public void AddOrUpdate_AddsValue_WithAddValueFactory_WhenKeyDoesNotExist()
        {
            var dict = new Dictionary<string, int>();
            var result = dict.AddOrUpdate("c", k => k.Length, (k, v) => v + 100);
            Assert.Equal(1, result);
            Assert.Equal(1, dict["c"]);
        }

        [Fact]
        public void AddOrUpdate_UpdatesValue_WithUpdateValueFactory_WhenKeyExists_AndAddValueFactory()
        {
            var dict = new Dictionary<string, int> { { "c", 7 } };
            var result = dict.AddOrUpdate("c", k => k.Length, (k, v) => v * 2);
            Assert.Equal(14, result);
            Assert.Equal(14, dict["c"]);
        }
    }
}
