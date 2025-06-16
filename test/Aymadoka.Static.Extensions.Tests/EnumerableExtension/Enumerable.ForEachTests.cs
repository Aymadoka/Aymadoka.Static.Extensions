namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_ForEachTests
    {
        [Fact]
        public void ForEach_WithActionAndIndex_ExecutesActionForEachElementWithCorrectIndex()
        {
            // Arrange
            var source = new List<string> { "a", "b", "c" };
            var result = new List<(string, int)>();

            // Act
            source.ForEach((item, index) => result.Add((item, index)));

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(("a", 0), result[0]);
            Assert.Equal(("b", 1), result[1]);
            Assert.Equal(("c", 2), result[2]);
        }

        [Fact]
        public void ForEach_WithAction_ExecutesActionForEachElement()
        {
            // Arrange
            var source = new List<int> { 1, 2, 3 };
            var result = new List<int>();

            // Act
            source.ForEach(item => result.Add(item * 2));

            // Assert
            Assert.Equal(new List<int> { 2, 4, 6 }, result);
        }

        [Fact]
        public void ForEach_WithEmptyCollection_DoesNotInvokeAction()
        {
            // Arrange
            var source = Enumerable.Empty<int>();
            var wasCalled = false;

            // Act
            source.ForEach(item => wasCalled = true);

            // Assert
            Assert.False(wasCalled);
        }

        [Fact]
        public void ForEach_WithNullAction_ThrowsArgumentNullException()
        {
            // Arrange
            var source = new List<int> { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => source.ForEach((Action<int, int>)null));
        }

        [Fact]
        public void ForEach_WithNullSource_ThrowsArgumentNullException()
        {
            // Arrange
            List<int> source = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => source.ForEach((item, index) => { }));
        }
    }
}
