namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_IsEmptyTests
    {
        [Fact]
        public void IsEmpty_WithEmptyList_ReturnsTrue()
        {
            var list = new List<int>();
            Assert.True(list.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WithNonEmptyList_ReturnsFalse()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.False(list.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WithEmptyArray_ReturnsTrue()
        {
            int[] array = new int[0];
            Assert.True(array.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WithNonEmptyArray_ReturnsFalse()
        {
            int[] array = { 1 };
            Assert.False(array.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WithEmptyEnumerable_ReturnsTrue()
        {
            IEnumerable<int> enumerable = Enumerable.Empty<int>();
            Assert.True(enumerable.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WithNonEmptyEnumerable_ReturnsFalse()
        {
            IEnumerable<int> enumerable = Enumerable.Range(1, 1);
            Assert.False(enumerable.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WithNull_ThrowsArgumentNullException()
        {
            IEnumerable<int> enumerable = null;
            Assert.Throws<System.ArgumentNullException>(() => enumerable.IsEmpty());
        }
    }
}
