using System.Collections.Specialized;

namespace Aymadoka.Static.NameValueCollectionExtension
{
    public class NameValueCollection_ToDictionaryTests
    {
        [Fact]
        public void ToDictionary_NullCollection_ReturnsEmptyDictionary()
        {
            NameValueCollection collection = null;

            var result = NameValueCollectionExtensions.ToDictionary(collection);

            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void ToDictionary_EmptyCollection_ReturnsEmptyDictionary()
        {
            var collection = new NameValueCollection();

            var result = collection.ToDictionary();

            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void ToDictionary_SingleKeyValuePair_ReturnsDictionaryWithOneItem()
        {
            var collection = new NameValueCollection
            {
                { "key1", "value1" }
            };

            var result = collection.ToDictionary();

            Assert.Single(result);
            Assert.Equal("value1", result["key1"]);
        }

        [Fact]
        public void ToDictionary_MultipleKeyValuePairs_ReturnsAllItems()
        {
            var collection = new NameValueCollection
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };

            var result = collection.ToDictionary();

            Assert.Equal(2, result.Count);
            Assert.Equal("value1", result["key1"]);
            Assert.Equal("value2", result["key2"]);
        }

        [Fact]
        public void ToDictionary_KeyWithNullValue_ReturnsNullValue()
        {
            var collection = new NameValueCollection
            {
                { "key1", null }
            };

            var result = collection.ToDictionary();

            Assert.Single(result);
            Assert.Null(result["key1"]);
        }
    }
}
