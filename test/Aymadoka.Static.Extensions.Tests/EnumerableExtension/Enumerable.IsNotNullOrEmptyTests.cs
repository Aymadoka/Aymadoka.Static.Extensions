namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_IsNotNullOrEmptyTests
    {
        [Fact]
        public void IsNotNullOrEmpty_WithNull_ReturnsFalse()
        {
            IEnumerable<int> source = null;
            Assert.False(source.IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_WithEmptyCollection_ReturnsFalse()
        {
            IEnumerable<int> source = new List<int>();
            Assert.False(source.IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_WithNonEmptyCollection_ReturnsTrue()
        {
            IEnumerable<int> source = new List<int> { 1 };
            Assert.True(source.IsNotNullOrEmpty());
        }
    }
}
