namespace Aymadoka.Static.ArrayExtension
{
    public class Array_WithinIndexTests
    {

        [Fact]
        public void WithinIndex_ValidIndex_ReturnsTrue()
        {
            // Arrange
            int[] arr = { 10, 20, 30 };

            // Act
            bool result0 = ArrayExtensions.WithinIndex(arr, 0);
            bool result2 = ArrayExtensions.WithinIndex(arr, 2);

            // Assert
            Assert.True(result0);
            Assert.True(result2);
        }

        [Fact]
        public void WithinIndex_InvalidIndex_ReturnsFalse()
        {
            // Arrange
            int[] arr = { 10, 20, 30 };

            // Act
            bool resultNegative = ArrayExtensions.WithinIndex(arr, -1);
            bool resultOutOfRange = ArrayExtensions.WithinIndex(arr, 3);

            // Assert
            Assert.False(resultNegative);
            Assert.False(resultOutOfRange);
        }

        [Fact]
        public void WithinIndex_EmptyArray_ReturnsFalse()
        {
            // Arrange
            int[] arr = Array.Empty<int>();

            // Act
            bool result0 = ArrayExtensions.WithinIndex(arr, 0);
            bool resultNegative = ArrayExtensions.WithinIndex(arr, -1);

            // Assert
            Assert.False(result0);
            Assert.False(resultNegative);
        }

        [Fact]
        public void WithinIndex_NullArray_ThrowsNullReferenceException()
        {
            // Arrange
            int[] arr = null;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => ArrayExtensions.WithinIndex(arr, 0));
        }

        [Fact]
        public void WithinIndex_WithDimension_ValidIndex_ReturnsTrue()
        {
            // Arrange
            int[] arr = { 10, 20, 30 };

            // Act
            bool result0 = ArrayExtensions.WithinIndex(arr, 0, 0);
            bool result2 = ArrayExtensions.WithinIndex(arr, 2, 0);

            // Assert
            Assert.True(result0);
            Assert.True(result2);
        }

        [Fact]
        public void WithinIndex_WithDimension_InvalidIndex_ReturnsFalse()
        {
            // Arrange
            int[] arr = { 10, 20, 30 };

            // Act
            bool resultNegative = ArrayExtensions.WithinIndex(arr, -1, 0);
            bool resultOutOfRange = ArrayExtensions.WithinIndex(arr, 3, 0);

            // Assert
            Assert.False(resultNegative);
            Assert.False(resultOutOfRange);
        }

        [Fact]
        public void WithinIndex_WithDimension_EmptyArray_ReturnsFalse()
        {
            // Arrange
            int[] arr = Array.Empty<int>();

            // Act
            bool result0 = ArrayExtensions.WithinIndex(arr, 0, 0);
            bool resultNegative = ArrayExtensions.WithinIndex(arr, -1, 0);

            // Assert
            Assert.False(result0);
            Assert.False(resultNegative);
        }

        [Fact]
        public void WithinIndex_WithDimension_NullArray_ThrowsNullReferenceException()
        {
            // Arrange
            int[] arr = null;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => ArrayExtensions.WithinIndex(arr, 0, 0));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        public void WithinIndex_WithDimension_InvalidDimension_ThrowsIndexOutOfRangeException(int dimension)
        {
            // Arrange
            int[] arr = { 10, 20, 30 };

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => ArrayExtensions.WithinIndex(arr, 0, dimension));
        }
    }
}
