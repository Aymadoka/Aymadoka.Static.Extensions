namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_RemoveRangeIfContainsTests
    {
        [Fact]
        public void RemoveRangeIfContains_RemovesExistingElements()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            list.RemoveRangeIfContains(2, 4);

            Assert.DoesNotContain(2, list);
            Assert.DoesNotContain(4, list);
            Assert.Equal(new List<int> { 1, 3, 5 }, list);
        }

        [Fact]
        public void RemoveRangeIfContains_IgnoresNonExistingElements()
        {
            var list = new List<string> { "a", "b", "c" };
            list.RemoveRangeIfContains("d", "e");

            Assert.Equal(new List<string> { "a", "b", "c" }, list);
        }

        [Fact]
        public void RemoveRangeIfContains_MixedExistingAndNonExisting()
        {
            var set = new HashSet<int> { 10, 20, 30 };
            set.RemoveRangeIfContains(20, 40, 10);

            Assert.DoesNotContain(10, set);
            Assert.DoesNotContain(20, set);
            Assert.Contains(30, set);
            Assert.Equal(1, set.Count);
        }

        [Fact]
        public void RemoveRangeIfContains_EmptyValues_DoesNothing()
        {
            var list = new List<int> { 1, 2, 3 };
            list.RemoveRangeIfContains();

            Assert.Equal(new List<int> { 1, 2, 3 }, list);
        }

        [Fact]
        public void RemoveRangeIfContains_NullableTypes()
        {
            var list = new List<int?> { 1, null, 3 };
            list.RemoveRangeIfContains(null, 3);

            Assert.Equal(new List<int?> { 1 }, list);
        }
    }
}
