namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_ToNameValueCollectionTests
    {
        [Fact]
        public void ToNameValueCollection_ReturnsNull_WhenDictionaryIsNull()
        {
            IDictionary<string, string> dict = null;
            var result = dict.ToNameValueCollection();
            Assert.Null(result);
        }

        [Fact]
        public void ToNameValueCollection_ReturnsEmptyCollection_WhenDictionaryIsEmpty()
        {
            var dict = new Dictionary<string, string>();
            var result = dict.ToNameValueCollection();
            Assert.NotNull(result);
            Assert.Equal(0, result.Count);
        }

        [Fact]
        public void ToNameValueCollection_ConvertsDictionaryToNameValueCollection()
        {
            var dict = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };
            var result = dict.ToNameValueCollection();
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("value1", result["key1"]);
            Assert.Equal("value2", result["key2"]);
        }
    }
}
