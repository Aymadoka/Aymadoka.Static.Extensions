namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_AddIfNotContainsKeyTests
    {
        [Fact]
        public void AddIfNotContainsKey_Adds_WhenKeyNotExists()
        {
            var dict = new Dictionary<string, int>();
            bool result = dict.AddIfNotContainsKey("a", 1);
            Assert.True(result);
            Assert.Equal(1, dict["a"]);
        }

        [Fact]
        public void AddIfNotContainsKey_DoesNotAdd_WhenKeyExists()
        {
            var dict = new Dictionary<string, int> { { "a", 1 } };
            bool result = dict.AddIfNotContainsKey("a", 2);
            Assert.False(result);
            Assert.Equal(1, dict["a"]);
        }

        [Fact]
        public void AddIfNotContainsKey_WithValueFactory_Adds_WhenKeyNotExists()
        {
            var dict = new Dictionary<string, int>();
            bool result = dict.AddIfNotContainsKey("b", () => 5);
            Assert.True(result);
            Assert.Equal(5, dict["b"]);
        }

        [Fact]
        public void AddIfNotContainsKey_WithValueFactory_DoesNotAdd_WhenKeyExists()
        {
            var dict = new Dictionary<string, int> { { "b", 3 } };
            bool result = dict.AddIfNotContainsKey("b", () => 7);
            Assert.False(result);
            Assert.Equal(3, dict["b"]);
        }

        [Fact]
        public void AddIfNotContainsKey_WithKeyedValueFactory_Adds_WhenKeyNotExists()
        {
            var dict = new Dictionary<string, string>();
            bool result = dict.AddIfNotContainsKey("c", k => k.ToUpper());
            Assert.True(result);
            Assert.Equal("C", dict["c"]);
        }

        [Fact]
        public void AddIfNotContainsKey_WithKeyedValueFactory_DoesNotAdd_WhenKeyExists()
        {
            var dict = new Dictionary<string, string> { { "c", "old" } };
            bool result = dict.AddIfNotContainsKey("c", k => "new");
            Assert.False(result);
            Assert.Equal("old", dict["c"]);
        }
    }
}
