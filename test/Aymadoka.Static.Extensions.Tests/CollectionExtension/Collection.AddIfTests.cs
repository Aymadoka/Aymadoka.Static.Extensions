namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_AddIfTests
    {
        [Fact]
        public void AddIf_ShouldAdd_WhenPredicateReturnsTrue()
        {
            var list = new List<int>();
            bool result = list.AddIf(x => x > 0, 5);
            Assert.True(result);
            Assert.Contains(5, list);
        }

        [Fact]
        public void AddIf_ShouldNotAdd_WhenPredicateReturnsFalse()
        {
            var list = new List<int>();
            bool result = list.AddIf(x => x < 0, 5);
            Assert.False(result);
            Assert.DoesNotContain(5, list);
        }

        [Fact]
        public void AddIf_ShouldWorkWithReferenceTypes()
        {
            var list = new List<string>();
            bool result = list.AddIf(s => !string.IsNullOrEmpty(s), "hello");
            Assert.True(result);
            Assert.Contains("hello", list);
        }

        [Fact]
        public void AddIf_ShouldNotAddNull_WhenPredicateReturnsFalse()
        {
            var list = new List<string>();
            bool result = list.AddIf(s => s != null, null);
            Assert.False(result);
            Assert.Empty(list);
        }

        [Fact]
        public void AddIf_ShouldThrowArgumentNullException_WhenCollectionIsNull()
        {
            List<int> list = null;
            Assert.Throws<NullReferenceException>(() => list.AddIf(x => true, 1));
        }

        [Fact]
        public void AddIf_ShouldThrowArgumentNullException_WhenPredicateIsNull()
        {
            var list = new List<int>();
            Assert.Throws<NullReferenceException>(() => list.AddIf(null, 1));
        }
    }
}
