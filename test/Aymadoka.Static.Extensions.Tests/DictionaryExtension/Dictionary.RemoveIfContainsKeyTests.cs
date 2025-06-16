namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_RemoveIfContainsKeyTests
    {
        [Fact]
        public void RemoveIfContainsKey_RemovesKey_WhenKeyExists()
        {
            var dict = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };

            dict.RemoveIfContainsKey("a");

            Assert.False(dict.ContainsKey("a"));
            Assert.True(dict.ContainsKey("b"));
        }

        [Fact]
        public void RemoveIfContainsKey_DoesNothing_WhenKeyDoesNotExist()
        {
            var dict = new Dictionary<string, int>
            {
                { "a", 1 }
            };

            dict.RemoveIfContainsKey("b");

            Assert.True(dict.ContainsKey("a"));
            Assert.False(dict.ContainsKey("b"));
        }
    }
}
