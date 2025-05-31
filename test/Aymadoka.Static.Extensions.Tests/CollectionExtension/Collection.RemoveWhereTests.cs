namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_RemoveWhereTests
    {
        [Fact]
        public void RemoveWhere_RemovesMatchingElements()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            list.RemoveWhere(x => x % 2 == 0);

            Assert.Equal(new List<int> { 1, 3, 5 }, list);
        }

        [Fact]
        public void RemoveWhere_RemovesAllElements_WhenAllMatch()
        {
            var list = new List<string> { "a", "a", "a" };
            list.RemoveWhere(s => s == "a");

            Assert.Empty(list);
        }

        [Fact]
        public void RemoveWhere_RemovesNoElements_WhenNoneMatch()
        {
            var list = new List<int> { 1, 3, 5 };
            list.RemoveWhere(x => x % 2 == 0);

            Assert.Equal(new List<int> { 1, 3, 5 }, list);
        }

        [Fact]
        public void RemoveWhere_ThrowsArgumentNullException_WhenPredicateIsNull()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.Throws<ArgumentNullException>(() => list.RemoveWhere(null));
        }

        [Fact]
        public void RemoveWhere_ThrowsArgumentNullException_WhenCollectionIsNull()
        {
            List<int> list = null;
            Assert.Throws<ArgumentNullException>(() => list.RemoveWhere(x => true));
        }
    }
}
