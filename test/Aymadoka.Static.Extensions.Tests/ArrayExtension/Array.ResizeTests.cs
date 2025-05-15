using System.Collections.ObjectModel;

namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ResizeTests
    {
        [Fact]
        public void Reverse_Array_ReversesElementsInPlace()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            array.Reverse();

            // Assert
            Assert.Equal(new[] { 5, 4, 3, 2, 1 }, array);
        }

        [Fact]
        public void Reverse_EmptyArray_NoException()
        {
            // Arrange
            int[] array = new int[0];

            // Act
            array.Reverse();

            // Assert
            Assert.Empty(array);
        }

        [Fact]
        public void Reverse_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.Reverse());
        }
    }
}
