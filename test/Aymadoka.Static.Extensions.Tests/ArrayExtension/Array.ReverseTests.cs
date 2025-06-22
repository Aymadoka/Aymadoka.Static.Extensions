using Xunit;
using System;

namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ReverseTests
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

        [Fact]
        public void Reverse_EntireArray_ReversesElements()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            arr.Reverse();
            Assert.Equal(new[] { 5, 4, 3, 2, 1 }, arr);
        }

        [Fact]
        public void Reverse_EntireArray_Null_ThrowsArgumentNullException()
        {
            int[] arr = null;
            Assert.Throws<ArgumentNullException>(() => arr.Reverse());
        }

        [Fact]
        public void Reverse_Range_ReversesSpecifiedRange()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            arr.Reverse(1, 3);
            Assert.Equal(new[] { 1, 4, 3, 2, 5 }, arr);
        }

        [Fact]
        public void Reverse_Range_Null_ThrowsArgumentNullException()
        {
            int[] arr = null;
            Assert.Throws<ArgumentNullException>(() => arr.Reverse(0, 1));
        }

        [Theory]
        [InlineData(-1, 2)]
        [InlineData(1, -2)]
        public void Reverse_Range_InvalidIndexOrLength_ThrowsArgumentOutOfRangeException(int index, int length)
        {
            int[] arr = { 1, 2, 3 };
            Assert.Throws<ArgumentOutOfRangeException>(() => arr.Reverse(index, length));
        }

        [Fact]
        public void Reverse_Range_InvalidRange_ThrowsArgumentException()
        {
            int[] arr = { 1, 2, 3 };
            Assert.Throws<ArgumentException>(() => arr.Reverse(2, 5));
        }
    }
}