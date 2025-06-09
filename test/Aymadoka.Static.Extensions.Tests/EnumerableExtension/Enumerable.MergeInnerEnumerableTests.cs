namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_MergeInnerEnumerableTests
    {
        [Fact]
        public void MergeInnerEnumerable_MergesMultipleEnumerables()
        {
            // Arrange
            var list1 = new List<int> { 1, 2 };
            var list2 = new List<int> { 3, 4 };
            var list3 = new List<int> { 5 };
            var source = new List<IEnumerable<int>> { list1, list2, list3 };

            // Act
            var result = source.MergeInnerEnumerable().ToList();

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public void MergeInnerEnumerable_EmptyOuterEnumerable_ReturnsEmpty()
        {
            // Arrange
            var source = new List<IEnumerable<int>>();

            // Act
            var result = source.MergeInnerEnumerable().ToList();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void MergeInnerEnumerable_ContainsEmptyInnerEnumerables()
        {
            // Arrange
            var list1 = new List<int>();
            var list2 = new List<int> { 1, 2 };
            var list3 = new List<int>();
            var source = new List<IEnumerable<int>> { list1, list2, list3 };

            // Act
            var result = source.MergeInnerEnumerable().ToList();

            // Assert
            Assert.Equal(new List<int> { 1, 2 }, result);
        }

        [Fact]
        public void MergeInnerEnumerable_AllInnerEnumerablesEmpty_ReturnsEmpty()
        {
            // Arrange
            var source = new List<IEnumerable<int>>
            {
                new List<int>(),
                new List<int>()
            };

            // Act
            var result = source.MergeInnerEnumerable().ToList();

            // Assert
            Assert.Empty(result);
        }
    }
}
