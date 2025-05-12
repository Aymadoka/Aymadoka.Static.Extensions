namespace Aymadoka.Static.ArrayExtension
{
    public class Array_CopyTests
    {
        [Fact]
        public void Copy_ShouldCopyElements_WhenParametersAreValid()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int length = 3;

            // Act
            sourceArray.Copy(destinationArray, length);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 0, 0 }, destinationArray);
        }

        [Fact]
        public void Copy_ShouldThrowArgumentNullException_WhenSourceArrayIsNull()
        {
            // Arrange
            int[] sourceArray = null;
            int[] destinationArray = new int[5];
            int length = 3;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sourceArray.Copy(destinationArray, length));
        }

        [Fact]
        public void Copy_ShouldThrowArgumentNullException_WhenDestinationArrayIsNull()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = null;
            int length = 3;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sourceArray.Copy(destinationArray, length));
        }

        [Fact]
        public void Copy_ShouldThrowArgumentException_WhenLengthExceedsSourceArray()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3 };
            int[] destinationArray = new int[5];
            int length = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sourceArray.Copy(destinationArray, length));
        }

        [Fact]
        public void Copy_WithIndices_ShouldCopyElements_WhenParametersAreValid()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = 1;
            int destinationIndex = 2;
            int length = 2;

            // Act
            sourceArray.Copy(sourceIndex, destinationArray, destinationIndex, length);

            // Assert
            Assert.Equal(new[] { 0, 0, 2, 3, 0 }, destinationArray);
        }

        [Fact]
        public void Copy_WithIndices_ShouldThrowArgumentOutOfRangeException_WhenSourceIndexIsNegative()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = -1;
            int destinationIndex = 0;
            int length = 2;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sourceArray.Copy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void Copy_WithLongLength_ShouldCopyElements_WhenParametersAreValid()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            long length = 3;

            // Act
            sourceArray.Copy(destinationArray, length);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 0, 0 }, destinationArray);
        }

        [Fact]
        public void Copy_WithLongIndices_ShouldCopyElements_WhenParametersAreValid()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            long sourceIndex = 1;
            long destinationIndex = 2;
            long length = 2;

            // Act
            sourceArray.Copy(sourceIndex, destinationArray, destinationIndex, length);

            // Assert
            Assert.Equal(new[] { 0, 0, 2, 3, 0 }, destinationArray);
        }

        [Fact]
        public void Copy_WithLongIndices_ShouldThrowArgumentOutOfRangeException_WhenLengthIsNegative()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            long sourceIndex = 0;
            long destinationIndex = 0;
            long length = -1;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sourceArray.Copy(sourceIndex, destinationArray, destinationIndex, length));
        }
    }
}
