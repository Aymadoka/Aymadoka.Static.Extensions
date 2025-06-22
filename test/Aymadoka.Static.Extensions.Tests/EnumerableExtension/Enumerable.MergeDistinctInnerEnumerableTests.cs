namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_MergeDistinctInnerEnumerableTests
    {
        [Fact]
        public void MergeDistinctInnerEnumerable_MergesAndRemovesDuplicates()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 3, 4, 5 },
                new List<int> { 5, 6 }
            };

            // Act
            var result = listOfLists.MergeDistinctInnerEnumerable().ToList();

            // Assert
            var expected = new List<int> { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(expected, result.OrderBy(x => x));
        }

        [Fact]
        public void MergeDistinctInnerEnumerable_EmptyOuterEnumerable_ReturnsEmpty()
        {
            // Arrange
            var listOfLists = new List<List<int>>();

            // Act
            var result = listOfLists.MergeDistinctInnerEnumerable().ToList();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void MergeDistinctInnerEnumerable_InnerEnumerablesAreEmpty_ReturnsEmpty()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int>(),
                new List<int>()
            };

            // Act
            var result = listOfLists.MergeDistinctInnerEnumerable().ToList();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void MergeDistinctInnerEnumerable_SingleInnerEnumerable_ReturnsDistinct()
        {
            // Arrange
            var listOfLists = new List<List<int>>
            {
                new List<int> { 1, 2, 2, 3 }
            };

            // Act
            var result = listOfLists.MergeDistinctInnerEnumerable().ToList();

            // Assert
            var expected = new List<int> { 1, 2, 3 };
            Assert.Equal(expected, result.OrderBy(x => x));
        }
    }
}
