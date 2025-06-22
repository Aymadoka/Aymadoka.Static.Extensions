namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_IsNotEmptyTests
    {
        [Fact]
        public void IsNotEmpty_WithNonEmptyEnumerable_ReturnsTrue()
        {
            IEnumerable<int> source = new List<int> { 1, 2, 3 };
            Assert.True(source.IsNotEmpty());
        }

        [Fact]
        public void IsNotEmpty_WithEmptyEnumerable_ReturnsFalse()
        {
            IEnumerable<int> source = Enumerable.Empty<int>();
            Assert.False(source.IsNotEmpty());
        }

        [Fact]
        public void IsNotEmpty_WithNullEnumerable_ThrowsArgumentNullException()
        {
            IEnumerable<int> source = null;
            Assert.Throws<System.ArgumentNullException>(() => source.IsNotEmpty());
        }
    }
}
