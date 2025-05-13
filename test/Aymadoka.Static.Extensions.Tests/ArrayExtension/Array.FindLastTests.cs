namespace Aymadoka.Static.ArrayExtension
{
    public class Array_FindLastTests
    {
        [Fact]
        public void FindLast_FindsLastMatchingElement()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 2, 5 };

            // Act
            int result = ArrayExtensions.FindLast(array, x => x == 2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindLast_NoMatch_ReturnsDefault()
        {
            // Arrange
            string[] array = { "a", "b", "c" };

            // Act
            var result = ArrayExtensions.FindLast(array, x => x == "z");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void FindLast_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLast(array, x => x == 1));
        }

        [Fact]
        public void FindLast_NullPredicate_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLast(array, null));
        }

        [Fact]
        public void FindLast_EmptyArray_ReturnsDefault()
        {
            // Arrange
            int[] array = Array.Empty<int>();

            // Act
            var result = ArrayExtensions.FindLast(array, x => x == 1);

            // Assert
            Assert.Equal(0, result); // int 的默认值为 0
        }
    }
}
