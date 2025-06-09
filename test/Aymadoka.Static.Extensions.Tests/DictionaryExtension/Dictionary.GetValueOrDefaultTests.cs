namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_GetValueOrDefaultTests
    {
        [Fact]
        public void ToSortedDictionary_ReturnsSortedDictionary_WithSameElements()
        {
            var dict = new Dictionary<int, string>
            {
                { 3, "three" },
                { 1, "one" },
                { 2, "two" }
            };

            var sorted = dict.ToSortedDictionary();

            Assert.IsType<SortedDictionary<int, string>>(sorted);
            Assert.Equal(dict.Count, sorted.Count);
            Assert.Equal(new[] { 1, 2, 3 }, new List<int>(sorted.Keys));
            Assert.Equal("one", sorted[1]);
            Assert.Equal("two", sorted[2]);
            Assert.Equal("three", sorted[3]);
        }

        [Fact]
        public void ToSortedDictionary_WithComparer_SortsAccordingToComparer()
        {
            var dict = new Dictionary<string, int>
            {
                { "b", 2 },
                { "a", 1 },
                { "C", 3 }
            };

            var sorted = dict.ToSortedDictionary(StringComparer.OrdinalIgnoreCase);

            Assert.IsType<SortedDictionary<string, int>>(sorted);
            Assert.Equal(dict.Count, sorted.Count);
            var expectedOrder = new List<string> { "a", "b", "C" };
            Assert.Equal(expectedOrder, new List<string>(sorted.Keys));
        }
    }
}
