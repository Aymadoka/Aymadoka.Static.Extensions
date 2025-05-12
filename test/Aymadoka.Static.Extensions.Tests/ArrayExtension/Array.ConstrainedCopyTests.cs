namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ConstrainedCopyTests
    {
        [Fact]
        public void ConstrainedCopy_ShouldCopyElements_WhenParametersAreValid()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = 1;
            int destinationIndex = 2;
            int length = 2;

            // Act
            sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length);

            // Assert
            Assert.Equal(new[] { 0, 0, 2, 3, 0 }, destinationArray);
        }

        [Fact]
        public void ConstrainedCopy_ShouldThrowArgumentNullException_WhenSourceArrayIsNull()
        {
            // Arrange
            int[] sourceArray = null;
            int[] destinationArray = new int[5];
            int sourceIndex = 0;
            int destinationIndex = 0;
            int length = 2;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void ConstrainedCopy_ShouldThrowArgumentNullException_WhenDestinationArrayIsNull()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = null;
            int sourceIndex = 0;
            int destinationIndex = 0;
            int length = 2;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void ConstrainedCopy_ShouldThrowArgumentOutOfRangeException_WhenSourceIndexIsNegative()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = -1;
            int destinationIndex = 0;
            int length = 2;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void ConstrainedCopy_ShouldThrowArgumentOutOfRangeException_WhenDestinationIndexIsNegative()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = 0;
            int destinationIndex = -1;
            int length = 2;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void ConstrainedCopy_ShouldThrowArgumentOutOfRangeException_WhenLengthIsNegative()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = 0;
            int destinationIndex = 0;
            int length = -1;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void ConstrainedCopy_ShouldThrowArgumentException_WhenSourceRangeIsInvalid()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = 4;
            int destinationIndex = 0;
            int length = 2;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void ConstrainedCopy_ShouldThrowArgumentException_WhenDestinationRangeIsInvalid()
        {
            // Arrange
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[5];
            int sourceIndex = 0;
            int destinationIndex = 4;
            int length = 2;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length));
        }

        [Fact]
        public void ConstrainedCopy_ShouldWorkForReferenceTypeArray()
        {
            // Arrange
            string[] sourceArray = { "a", "b", "c", "d" };
            string[] destinationArray = new string[4];
            int sourceIndex = 1;
            int destinationIndex = 2;
            int length = 2;

            // Act
            sourceArray.ConstrainedCopy(sourceIndex, destinationArray, destinationIndex, length);

            // Assert
            Assert.Equal(new[] { null, null, "b", "c" }, destinationArray);
        }
    }
}
