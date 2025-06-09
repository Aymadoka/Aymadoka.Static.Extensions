namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_ContainsAllTests
    {
        [Fact]
        public void ContainsAll_ReturnsTrue_WhenAllValuesAreContained()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            Assert.True(source.ContainsAll(2, 3, 5));
        }

        [Fact]
        public void ContainsAll_ReturnsFalse_WhenSomeValuesAreNotContained()
        {
            var source = new[] { 1, 2, 3 };
            Assert.False(source.ContainsAll(2, 4));
        }

        [Fact]
        public void ContainsAll_ReturnsTrue_WhenValuesIsEmpty()
        {
            var source = new[] { 1, 2, 3 };
            Assert.True(source.ContainsAll());
        }

        [Fact]
        public void ContainsAll_ReturnsFalse_WhenSourceIsEmptyAndValuesIsNotEmpty()
        {
            var source = new int[0];
            Assert.False(source.ContainsAll(1));
        }

        [Fact]
        public void ContainsAll_ReturnsTrue_WhenSourceAndValuesAreEmpty()
        {
            var source = new int[0];
            Assert.True(source.ContainsAll());
        }

        [Fact]
        public void ContainsAll_WorksWithReferenceTypes()
        {
            var source = new[] { "a", "b", "c" };
            Assert.True(source.ContainsAll("a", "b"));
            Assert.False(source.ContainsAll("a", "d"));
        }
    }
}
