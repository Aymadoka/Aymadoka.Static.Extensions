namespace Aymadoka.Static.ArrayExtension
{
    public class Array_FindAllTests
    {
        [Fact]
        public void FindAll_ReturnsAllMatchingElements_WhenElementsExist()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // Act
            int[] result = numbers.FindAll(n => n % 2 == 0);

            // Assert
            Assert.Equal(new[] { 2, 4, 6 }, result);
        }

        [Fact]
        public void FindAll_ReturnsEmptyArray_WhenNoElementMatchesPredicate()
        {
            // Arrange
            string[] words = { "apple", "banana", "cherry" };

            // Act
            string[] result = words.FindAll(w => w == "orange");

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void FindAll_ReturnsAllElements_WhenPredicateAlwaysTrue()
        {
            // Arrange
            int[] numbers = { 7, 8, 9 };

            // Act
            int[] result = numbers.FindAll(n => true);

            // Assert
            Assert.Equal(numbers, result);
        }

        [Fact]
        public void FindAll_ThrowsArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] numbers = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => numbers.FindAll(n => n > 0));
        }

        [Fact]
        public void FindAll_ThrowsArgumentNullException_WhenPredicateIsNull()
        {
            // Arrange
            int[] numbers = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => numbers.FindAll(null));
        }
    }
}
