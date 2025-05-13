namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ExistsTests
    {
        [Fact]
        public void Exists_ReturnsTrue_WhenElementMatchesPredicate()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Act
            bool result = numbers.Exists(n => n == 3);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Exists_ReturnsFalse_WhenNoElementMatchesPredicate()
        {
            // Arrange
            string[] words = { "apple", "banana", "cherry" };

            // Act
            bool result = words.Exists(w => w == "orange");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Exists_ThrowsArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] numbers = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => numbers.Exists(n => n == 1));
        }

        [Fact]
        public void Exists_ThrowsArgumentNullException_WhenPredicateIsNull()
        {
            // Arrange
            int[] numbers = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => numbers.Exists(null));
        }
    }
}
