using System.Collections.ObjectModel;

namespace Aymadoka.Static.ArrayExtension
{
    public class Array_IndexOfTests
    {
        [Fact]
        public void IndexOf_ValueExists_ReturnsFirstIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int index = ArrayExtensions.IndexOf(array, 2);

            // Assert
            Assert.Equal(1, index);
        }

        [Fact]
        public void IndexOf_ValueDoesNotExist_ReturnsMinusOne()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act
            int index = ArrayExtensions.IndexOf(array, 100);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void IndexOf_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.IndexOf(array, 1));
        }

        [Fact]
        public void IndexOf_WithStartIndex_FindsCorrectIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int index = ArrayExtensions.IndexOf(array, 2, 2);

            // Assert
            Assert.Equal(3, index);
        }

        [Fact]
        public void IndexOf_WithStartIndexAndCount_FindsCorrectIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int index = ArrayExtensions.IndexOf(array, 2, 2, 2);

            // Assert
            Assert.Equal(3, index);
        }

        [Fact]
        public void IndexOf_WithStartIndex_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.IndexOf(array, 2, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.IndexOf(array, 2, 4));
        }

        [Fact]
        public void IndexOf_WithStartIndexAndCount_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.IndexOf(array, 2, 1, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.IndexOf(array, 2, -1, 2));
        }
    }
}
