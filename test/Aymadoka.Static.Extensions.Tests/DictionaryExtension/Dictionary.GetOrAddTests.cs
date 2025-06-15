namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_GetOrAddTests
    {
        [Fact]
        public void GetOrAdd_ValueExists_ReturnsExistingValue()
        {
            var dict = new Dictionary<string, int> { { "a", 1 } };

            var result = dict.GetOrAdd("a", 2);

            Assert.Equal(1, result);
            Assert.Single(dict);
        }

        [Fact]
        public void GetOrAdd_ValueNotExists_AddsAndReturnsValue()
        {
            var dict = new Dictionary<string, int>();

            var result = dict.GetOrAdd("b", 3);

            Assert.Equal(3, result);
            Assert.True(dict.ContainsKey("b"));
            Assert.Equal(3, dict["b"]);
        }

        [Fact]
        public void GetOrAdd_Factory_ValueExists_ReturnsExistingValue()
        {
            var dict = new Dictionary<string, int> { { "x", 10 } };
            bool factoryCalled = false;

            int Factory(string key)
            {
                factoryCalled = true;
                return 99;
            }

            var result = dict.GetOrAdd("x", Factory);

            Assert.Equal(10, result);
            Assert.False(factoryCalled);
        }

        [Fact]
        public void GetOrAdd_Factory_ValueNotExists_AddsAndReturnsFactoryValue()
        {
            var dict = new Dictionary<string, int>();

            int Factory(string key) => key.Length;

            var result = dict.GetOrAdd("hello", Factory);

            Assert.Equal(5, result);
            Assert.True(dict.ContainsKey("hello"));
            Assert.Equal(5, dict["hello"]);
        }

        [Fact]
        public void GetOrAdd_NullDictionary_ThrowsArgumentNullException()
        {
            IDictionary<string, int> dict = null;
            Assert.Throws<NullReferenceException>(() => dict.GetOrAdd("a", 1));
            Assert.Throws<NullReferenceException>(() => dict.GetOrAdd("a", k => 1));
        }

        [Fact]
        public void GetOrAdd_Factory_NullFactory_ThrowsArgumentNullException()
        {
            var dict = new Dictionary<string, int>();
            Assert.Throws<NullReferenceException>(() => dict.GetOrAdd("a", null));
        }
    }
}
