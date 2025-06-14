using Xunit;
using System;

namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ReverseTests
    {
        [Fact]
        public void Reverse_NonEmptyArray_ReversesElements()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 5, 4, 3, 2, 1 };

            // Act  
            array.Reverse();

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void Reverse_EmptyArray_NoException()
        {
            // Arrange
            int[] array = Array.Empty<int>();

            // Act & Assert (should not throw)
            array.Reverse();
        }

        [Fact]
        public void Reverse_SingleElementArray_Unchanged()
        {
            // Arrange
            string[] array = { "test" };
            string[] expected = { "test" };

            // Act
            array.Reverse();

            // Assert
            Assert.Equal(expected, array);
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