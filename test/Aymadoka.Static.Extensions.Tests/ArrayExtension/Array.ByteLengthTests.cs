namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ByteLengthTests
    {
        [Fact]
        public void ByteLength_ShouldReturnCorrectLength_ForIntArray()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4 };

            // Act
            int result = array.ByteLength();

            // Assert
            Assert.Equal(16, result); // 4 elements * 4 bytes per int = 16 bytes
        }

        [Fact]
        public void ByteLength_ShouldReturnCorrectLength_ForByteArray()
        {
            // Arrange
            byte[] array = { 1, 2, 3, 4, 5 };

            // Act
            int result = array.ByteLength();

            // Assert
            Assert.Equal(5, result); // 5 elements * 1 byte per byte = 5 bytes
        }

        [Fact]
        public void ByteLength_ShouldReturnZero_ForEmptyArray()
        {
            // Arrange
            int[] array = Array.Empty<int>();

            // Act
            int result = array.ByteLength();

            // Assert
            Assert.Equal(0, result); // Empty array has 0 bytes
        }

        [Fact]
        public void ByteLength_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.ByteLength());
        }

        [Fact]
        public void ByteLength_ShouldReturnCorrectLength_ForDateTimeArray()
        {
            // Arrange
            var array = new DateTime[2]; // DateTime is a struct

            // Act
            int result = array.ByteLength();

            // Assert
            Assert.Equal(16, result); // 2 elements * 8 bytes per DateTime = 16 bytes
        }

        [Fact]
        public void ByteLength_ShouldThrowArgumentException_ForNonPrimitiveArray()
        {
            // Arrange
            var array = new string[] { "a", "b", "c" }; // Non-primitive type

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => array.ByteLength());
            Assert.Equal("Object must be an array of primitives or DateTime. (Parameter 'this')", exception.Message);
        }
    }
}
