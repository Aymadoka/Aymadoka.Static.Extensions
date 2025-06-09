namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_ToSortedDictionaryTests
    {
        [Fact]
        public void GetValueOrDefault_ReferenceType_KeyExists_ReturnsValue()
        {
            var dict = new Dictionary<string, string>
            {
                { "a", "apple" }
            };

            var result = dict.GetValueOrDefault("a", "default");
            Assert.Equal("apple", result);
        }

        [Fact]
        public void GetValueOrDefault_ReferenceType_KeyNotExists_ReturnsDefault()
        {
            var dict = new Dictionary<string, string>
            {
                { "a", "apple" }
            };

            var result = dict.GetValueOrDefault("b", "default");
            Assert.Equal("default", result);
        }

        [Fact]
        public void GetValueOrDefault_ReferenceType_KeyNotExists_DefaultIsNull()
        {
            var dict = new Dictionary<string, string>
            {
                { "a", "apple" }
            };

            var result = dict.GetValueOrDefault("b");
            Assert.Null(result);
        }

        [Fact]
        public void GetValueOrDefault_ValueType_KeyExists_ReturnsValue()
        {
            var dict = new Dictionary<int, int>
            {
                { 1, 100 }
            };

            var result = dict.GetValueOrDefault(1, 200);
            Assert.Equal(100, result);
        }

        [Fact]
        public void GetValueOrDefault_ValueType_KeyNotExists_ReturnsDefault()
        {
            var dict = new Dictionary<int, int>
            {
                { 1, 100 }
            };

            var result = dict.GetValueOrDefault(2, 200);
            Assert.Equal(200, result);
        }

        [Fact]
        public void GetValueOrDefault_ReferenceType_NullDictionary_Throws()
        {
            Dictionary<string, string> dict = null;
            Assert.Throws<ArgumentNullException>(() => dict.GetValueOrDefault("a", "default"));
        }

        [Fact]
        public void GetValueOrDefault_ValueType_NullDictionary_Throws()
        {
            Dictionary<int, int> dict = null;
            Assert.Throws<ArgumentNullException>(() => dict.GetValueOrDefault(1, 2));
        }
    }
}
