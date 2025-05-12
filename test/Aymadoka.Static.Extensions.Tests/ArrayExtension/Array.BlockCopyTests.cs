namespace Aymadoka.Static.ArrayExtension
{
    public class Array_BlockCopyTests
    {
        [Fact]
        public void BlockCopy_ShouldCopyElements_WhenParametersAreValid()
        {
            // Arrange
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = new int[5];
            int srcOffset = 1 * sizeof(int); // Offset in bytes
            int dstOffset = 0 * sizeof(int); // Offset in bytes
            int count = 3 * sizeof(int); // Number of bytes to copy

            // Act
            source.BlockCopy(srcOffset, destination, dstOffset, count);

            // Assert
            Assert.Equal(new[] { 2, 3, 4, 0, 0 }, destination);
        }

        [Fact]
        public void BlockCopy_ShouldThrowArgumentNullException_WhenSourceIsNull()
        {
            // Arrange
            int[] source = null;
            int[] destination = new int[5];
            int srcOffset = 0;
            int dstOffset = 0;
            int count = 4;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => source.BlockCopy(srcOffset, destination, dstOffset, count));
        }

        [Fact]
        public void BlockCopy_ShouldThrowArgumentNullException_WhenDestinationIsNull()
        {
            // Arrange
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = null;
            int srcOffset = 0;
            int dstOffset = 0;
            int count = 4;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => source.BlockCopy(srcOffset, destination, dstOffset, count));
        }

        [Fact]
        public void BlockCopy_ShouldThrowArgumentException_WhenOffsetsOrCountAreInvalid()
        {
            // Arrange
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = new int[5];
            int srcOffset = 6 * sizeof(int); // Invalid offset
            int dstOffset = 0;
            int count = 4;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => source.BlockCopy(srcOffset, destination, dstOffset, count));
        }

        [Fact]
        public void BlockCopy_ShouldThrowArgumentException_WhenCountExceedsSourceLength()
        {
            // Arrange
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = new int[5];
            int srcOffset = 0;
            int dstOffset = 0;
            int count = 6 * sizeof(int); // Exceeds source length

            // Act & Assert
            Assert.Throws<ArgumentException>(() => source.BlockCopy(srcOffset, destination, dstOffset, count));
        }

        [Fact]
        public void BlockCopy_ShouldThrowArgumentException_WhenCountExceedsDestinationLength()
        {
            // Arrange
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = new int[3];
            int srcOffset = 0;
            int dstOffset = 0;
            int count = 4 * sizeof(int); // Exceeds destination length

            // Act & Assert
            Assert.Throws<ArgumentException>(() => source.BlockCopy(srcOffset, destination, dstOffset, count));
        }
    }
}
