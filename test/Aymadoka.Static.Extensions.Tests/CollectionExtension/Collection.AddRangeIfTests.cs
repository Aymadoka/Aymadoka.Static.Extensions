namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_AddRangeIfTests
    {
        [Fact]
        public void AddRangeIf_AddsOnlyMatchingElements()
        {
            var list = new List<int>();
            list.AddRangeIf(x => x % 2 == 0, 1, 2, 3, 4, 5);

            Assert.Equal(new List<int> { 2, 4 }, list);
        }

        [Fact]
        public void AddRangeIf_AddsNothingIfNoMatch()
        {
            var list = new List<string>();
            list.AddRangeIf(s => s.StartsWith("A"), "B", "C", "D");

            Assert.Empty(list);
        }

        [Fact]
        public void AddRangeIf_AddsAllIfAllMatch()
        {
            var list = new List<int>();
            list.AddRangeIf(x => x > 0, 1, 2, 3);

            Assert.Equal(new List<int> { 1, 2, 3 }, list);
        }

        [Fact]
        public void AddRangeIf_HandlesEmptyValues()
        {
            var list = new List<int>();
            list.AddRangeIf(x => true);

            Assert.Empty(list);
        }

        [Fact]
        public void AddRangeIf_ThrowsIfPredicateIsNull()
        {
            var list = new List<int>();
            Assert.Throws<NullReferenceException>(() => list.AddRangeIf(null, 1, 2));
        }
    }
}
