namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_RemoveRangeTests
    {
        [Fact]
        public void RemoveRange_RemovesSpecifiedElements()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            list.RemoveRange(2, 2);

            // Assert
            Assert.DoesNotContain(3, list);
            Assert.DoesNotContain(4, list);
            Assert.Contains(1, list);
            Assert.Contains(2, list);
            Assert.Contains(5, list);
            Assert.Equal(3, list.Count);
        }

        [Fact]
        public void RemoveRange_WithNoValues_DoesNothing()
        {
            // Arrange
            var list = new List<string> { "a", "b", "c" };

            // Act
            list.RemoveRange();

            // Assert
            Assert.Equal(3, list.Count);
            Assert.Contains("a", list);
            Assert.Contains("b", list);
            Assert.Contains("c", list);
        }

        [Fact]
        public void RemoveRange_RemovesDuplicatesOnce()
        {
            // Arrange
            var list = new List<int> { 1, 2, 2, 3 };

            // Act
            list.RemoveRange(2);

            // Assert
            Assert.Equal(3, list.Count);
            Assert.Equal(new List<int> { 1, 2, 3 }, list);
        }
    }
}
