namespace Aymadoka.Static.ArrayExtension
{
    public class Array_FindLastIndexTests
    {
        [Fact]
        public void FindLastIndex_FindsLastMatchingIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int result = ArrayExtensions.FindLastIndex(array, x => x == 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void FindLastIndex_NoMatch_ReturnsMinusOne()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act
            int result = ArrayExtensions.FindLastIndex(array, x => x == 100);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void FindLastIndex_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLastIndex(array, x => x == 1));
        }

        [Fact]
        public void FindLastIndex_NullPredicate_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLastIndex(array, null));
        }

        [Fact]
        public void FindLastIndex_WithStartIndex_FindsLastMatchingIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int result = ArrayExtensions.FindLastIndex(array, 2, x => x == 2);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void FindLastIndex_WithStartIndex_NoMatch_ReturnsMinusOne()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act
            int result = ArrayExtensions.FindLastIndex(array, 1, x => x == 100);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void FindLastIndex_WithStartIndex_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLastIndex(array, 0, x => x == 1));
        }

        [Fact]
        public void FindLastIndex_WithStartIndex_NullPredicate_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLastIndex(array, 0, null));
        }

        [Fact]
        public void FindLastIndex_WithStartIndex_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindLastIndex(array, -1, x => x == 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindLastIndex(array, 3, x => x == 1));
        }

        [Fact]
        public void FindLastIndex_WithStartIndexAndCount_FindsLastMatchingIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int result = ArrayExtensions.FindLastIndex(array, 3, 3, x => x == 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void FindLastIndex_WithStartIndexAndCount_NoMatch_ReturnsMinusOne()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 5 };

            // Act
            int result = ArrayExtensions.FindLastIndex(array, 4, 2, x => x == 100);
            
            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void FindLastIndex_WithStartIndexAndCount_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLastIndex(array, 0, 1, x => x == 1));
        }

        [Fact]
        public void FindLastIndex_WithStartIndexAndCount_NullPredicate_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindLastIndex(array, 0, 1, null));
        }

        [Fact]
        public void FindLastIndex_WithStartIndexAndCount_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindLastIndex(array, -1, 2, x => x == 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindLastIndex(array, 2, 5, x => x == 1));
        }
    }
}
