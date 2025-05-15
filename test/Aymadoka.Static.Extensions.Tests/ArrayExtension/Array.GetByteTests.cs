namespace Aymadoka.Static.ArrayExtension
{
    public class Array_GetByteTests
    {
        [Fact]
        public void GetByte_ValidArrayAndIndex_ReturnsExpectedByte()
        {
            // Arrange
            int[] array = { 0x12345678 };
            // 0x12345678 的字节序列（小端）：0x78, 0x56, 0x34, 0x12

            // Act
            byte b0 = ArrayExtensions.GetByte(array, 0);
            byte b1 = ArrayExtensions.GetByte(array, 1);
            byte b2 = ArrayExtensions.GetByte(array, 2);
            byte b3 = ArrayExtensions.GetByte(array, 3);

            // Assert
            Assert.Equal(0x78, b0);
            Assert.Equal(0x56, b1);
            Assert.Equal(0x34, b2);
            Assert.Equal(0x12, b3);
        }

        [Fact]
        public void GetByte_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.GetByte(array, 0));
        }

        [Fact]
        public void GetByte_IndexOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 1 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.GetByte(array, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.GetByte(array, sizeof(int)));
        }

        [Fact]
        public void GetByte_ReferenceTypeArray_ThrowsArgumentException()
        {
            // Arrange
            string[] array = { "a", "b" };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => ArrayExtensions.GetByte(array, 0));
        }
    }
}
