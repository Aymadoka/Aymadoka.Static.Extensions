namespace Aymadoka.Static.ArrayExtension
{
    public class Array_FindTests
    {
        [Fact]
        public void Find_ReturnsFirstMatchingElement_WhenElementExists()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Act
            int result = numbers.Find(n => n > 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Find_ReturnsDefault_WhenNoElementMatchesPredicate()
        {
            // Arrange
            string[] words = { "apple", "banana", "cherry" };

            // Act
            string result = words.Find(w => w == "orange");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Find_ThrowsArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] numbers = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => numbers.Find(n => n == 1));
        }

        [Fact]
        public void Find_ThrowsArgumentNullException_WhenPredicateIsNull()
        {
            // Arrange
            int[] numbers = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => numbers.Find(null));
        }
    }
}
