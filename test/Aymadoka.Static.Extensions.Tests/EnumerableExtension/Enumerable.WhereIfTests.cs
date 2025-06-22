namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_WhereIfTests
    {
        [Fact]
        public void WhereIf_WithConditionTrue_FiltersElements()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var result = source.WhereIf(x => x > 2, true).ToArray();
            Assert.Equal(new[] { 3, 4, 5 }, result);
        }

        [Fact]
        public void WhereIf_WithConditionFalse_ReturnsOriginalSequence()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var result = source.WhereIf(x => x > 2, false).ToArray();
            Assert.Equal(source, result);
        }

        [Fact]
        public void WhereIf_WithIndexPredicate_ConditionTrue_FiltersElements()
        {
            var source = new[] { "a", "b", "c", "d" };
            var result = source.WhereIf((x, i) => i % 2 == 0, true).ToArray();
            Assert.Equal(new[] { "a", "c" }, result);
        }

        [Fact]
        public void WhereIf_WithIndexPredicate_ConditionFalse_ReturnsOriginalSequence()
        {
            var source = new[] { "a", "b", "c", "d" };
            var result = source.WhereIf((x, i) => i % 2 == 0, false).ToArray();
            Assert.Equal(source, result);
        }

        [Fact]
        public void WhereIf_NullSource_ThrowsArgumentNullException()
        {
            IEnumerable<int> source = null;
            Assert.Throws<ArgumentNullException>(() => source.WhereIf(x => x > 0, true).ToArray());
        }
    }
}
