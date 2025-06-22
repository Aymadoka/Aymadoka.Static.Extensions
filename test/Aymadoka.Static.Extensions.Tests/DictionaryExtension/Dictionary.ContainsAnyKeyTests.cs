namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_ContainsAnyKeyTests
    {
        [Fact]
        public void ContainsAnyKey_ReturnsTrue_WhenAnyKeyExists()
        {
            var dict = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };

            Assert.True(dict.ContainsAnyKey("a", "x"));
            Assert.True(dict.ContainsAnyKey("b"));
            Assert.True(dict.ContainsAnyKey("x", "b", "y"));
        }

        [Fact]
        public void ContainsAnyKey_ReturnsFalse_WhenNoKeyExists()
        {
            var dict = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };

            Assert.False(dict.ContainsAnyKey("x", "y", "z"));
            Assert.False(dict.ContainsAnyKey());
        }

        [Fact]
        public void ContainsAnyKey_ReturnsFalse_WhenDictionaryIsEmpty()
        {
            var dict = new Dictionary<string, int>();

            Assert.False(dict.ContainsAnyKey("a", "b"));
        }
    }
}
