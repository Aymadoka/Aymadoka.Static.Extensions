namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_IsNullOrEmptyTests
    {
        [Fact]
        public void IsNullOrEmpty_NullEnumerable_ReturnsTrue()
        {
            IEnumerable<int> source = null;
            Assert.True(source.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyList_ReturnsTrue()
        {
            var source = new List<int>();
            Assert.True(source.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_NonEmptyList_ReturnsFalse()
        {
            var source = new List<int> { 1 };
            Assert.False(source.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyArray_ReturnsTrue()
        {
            int[] source = new int[0];
            Assert.True(source.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_NonEmptyArray_ReturnsFalse()
        {
            int[] source = { 1, 2, 3 };
            Assert.False(source.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyEnumerable_ReturnsTrue()
        {
            IEnumerable<int> source = Enumerable.Empty<int>();
            Assert.True(source.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_NonEmptyEnumerable_ReturnsFalse()
        {
            IEnumerable<int> source = Enumerable.Range(1, 1);
            Assert.False(source.IsNullOrEmpty());
        }
    }
}
