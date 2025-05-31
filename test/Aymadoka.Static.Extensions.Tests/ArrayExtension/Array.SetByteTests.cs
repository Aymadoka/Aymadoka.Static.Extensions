namespace Aymadoka.Static.ArrayExtension
{
    public class Array_SetByteTests
    {
        [Fact]
        public void SetByte_ValidIndex_ChangesArrayByte()
        {
            // Arrange
            int[] array = { 0 };
            // int 占4字节，初始为 0x00 00 00 00

            // Act
            ArrayExtensions.SetByte(array, 0, 0xFF);

            // Assert
            // 只修改了第一个字节，剩下的字节仍为0
            Assert.Equal(0xFF, ArrayExtensions.GetByte(array, 0));
            Assert.Equal(0x00, ArrayExtensions.GetByte(array, 1));
            Assert.Equal(0x00, ArrayExtensions.GetByte(array, 2));
            Assert.Equal(0x00, ArrayExtensions.GetByte(array, 3));
        }

        [Fact]
        public void SetByte_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.SetByte(array, 0, 0xFF));
        }

        [Fact]
        public void SetByte_IndexOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 0 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.SetByte(array, -1, 0xFF));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.SetByte(array, 4, 0xFF)); // int[1] 只有4个字节，索引4越界
        }

        [Fact]
        public void SetByte_ReferenceTypeArray_ThrowsArgumentException()
        {
            // Arrange
            string[] array = { "a", "b" };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => ArrayExtensions.SetByte(array, 0, 0xFF));
        }
    }
}
