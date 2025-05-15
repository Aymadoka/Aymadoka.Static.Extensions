namespace Aymadoka.Static.ArrayExtension
{
    public class Array_LastIndexOfTests
    {
        [Fact]
        public void LastIndexOf_ValueExists_ReturnsLastIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int index = ArrayExtensions.LastIndexOf(array, 2);

            // Assert
            Assert.Equal(3, index);
        }

        [Fact]
        public void LastIndexOf_ValueDoesNotExist_ReturnsMinusOne()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act
            int index = ArrayExtensions.LastIndexOf(array, 100);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void LastIndexOf_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.LastIndexOf(array, 1));
        }

        [Fact]
        public void LastIndexOf_WithStartIndex_FindsCorrectIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int index = ArrayExtensions.LastIndexOf(array, 2, 2);

            // Assert
            Assert.Equal(1, index);
        }

        [Fact]
        public void LastIndexOf_WithStartIndexAndCount_FindsCorrectIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int index = ArrayExtensions.LastIndexOf(array, 2, 3, 3);

            // Assert
            Assert.Equal(3, index);
        }

        [Fact]
        public void LastIndexOf_WithStartIndex_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.LastIndexOf(array, 2, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.LastIndexOf(array, 2, 3));
        }

        [Fact]
        public void LastIndexOf_WithStartIndexAndCount_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.LastIndexOf(array, 2, 1, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.LastIndexOf(array, 2, -1, 2));
        }
    }
}
