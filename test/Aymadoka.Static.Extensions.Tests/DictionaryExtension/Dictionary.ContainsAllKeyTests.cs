namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_ContainsAllKeyTests
    {
        [Fact]
        public void ContainsAllKey_AllKeysPresent_ReturnsTrue()
        {
            var dict = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 },
                { "c", 3 }
            };

            Assert.True(dict.ContainsAllKey("a", "b"));
            Assert.True(dict.ContainsAllKey("a", "b", "c"));
        }

        [Fact]
        public void ContainsAllKey_SomeKeysMissing_ReturnsFalse()
        {
            var dict = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };

            Assert.False(dict.ContainsAllKey("a", "b", "c"));
            Assert.False(dict.ContainsAllKey("c"));
        }

        [Fact]
        public void ContainsAllKey_EmptyKeys_ReturnsTrue()
        {
            var dict = new Dictionary<string, int>
            {
                { "a", 1 }
            };

            Assert.True(dict.ContainsAllKey());
        }

        [Fact]
        public void ContainsAllKey_EmptyDictionary_ReturnsFalseUnlessNoKeys()
        {
            var dict = new Dictionary<string, int>();

            Assert.False(dict.ContainsAllKey("a"));
            Assert.True(dict.ContainsAllKey());
        }
    }
}
