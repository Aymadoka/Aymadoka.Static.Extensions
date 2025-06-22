namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_AddRangeIfNotContainsTests
    {
        [Fact]
        public void AddRangeIfNotContains_AddsUniqueElements()
        {
            var list = new List<int> { 1, 2 };
            list.AddRangeIfNotContains(2, 3, 4);

            Assert.Equal(new List<int> { 1, 2, 3, 4 }, list);
        }

        [Fact]
        public void AddRangeIfNotContains_DoesNotAddDuplicates()
        {
            var set = new HashSet<string> { "a", "b" };
            set.AddRangeIfNotContains("a", "b", "c");

            Assert.Contains("a", set);
            Assert.Contains("b", set);
            Assert.Contains("c", set);
            Assert.Equal(3, set.Count);
        }

        [Fact]
        public void AddRangeIfNotContains_EmptyValues_DoesNothing()
        {
            var list = new List<int> { 1, 2 };
            list.AddRangeIfNotContains();

            Assert.Equal(new List<int> { 1, 2 }, list);
        }

        [Fact]
        public void AddRangeIfNotContains_AllDuplicates_DoesNothing()
        {
            var list = new List<int> { 1, 2 };
            list.AddRangeIfNotContains(1, 2);

            Assert.Equal(new List<int> { 1, 2 }, list);
        }
    }
}
