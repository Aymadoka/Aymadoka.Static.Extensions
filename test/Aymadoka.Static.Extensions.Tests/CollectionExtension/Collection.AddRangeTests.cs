namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_AddRangeTests
    {
        [Fact]
        public void AddRange_ShouldAddAllElements()
        {
            var list = new List<int> { 1, 2 };
            list.AddRange(3, 4, 5);
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, list);
        }

        [Fact]
        public void AddRange_WithEmptyValues_ShouldNotChangeCollection()
        {
            var list = new List<string> { "a", "b" };
            list.AddRange();
            Assert.Equal(new List<string> { "a", "b" }, list);
        }

        [Fact]
        public void AddRange_WithNullValues_ShouldThrow()
        {
            var list = new List<int>();
            Assert.Throws<System.ArgumentNullException>(() => CollectionExtensions.AddRange<int>(null, 1, 2));
        }
    }
}
