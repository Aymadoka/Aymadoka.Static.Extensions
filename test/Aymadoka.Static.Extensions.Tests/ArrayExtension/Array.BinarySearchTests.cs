using System.Collections.ObjectModel;

namespace Aymadoka.Static.ArrayExtension
{
    public class Array_BinarySearchTests
    {
        [Fact]
        public void BinarySearch_ShouldReturnIndex_WhenValueExists()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int valueToSearch = 5;

            // Act
            int result = array.BinarySearch(valueToSearch);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void BinarySearch_ShouldReturnNegative_WhenValueDoesNotExist()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int valueToSearch = 4;

            // Act
            int result = array.BinarySearch(valueToSearch);

            // Assert
            Assert.True(result < 0);
        }

        [Fact]
        public void BinarySearch_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] array = null;
            int valueToSearch = 5;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.BinarySearch(valueToSearch));
        }

        [Fact]
        public void BinarySearch_WithRange_ShouldReturnIndex_WhenValueExists()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int valueToSearch = 7;
            int index = 1;
            int length = 3;

            // Act
            int result = array.BinarySearch(index, length, valueToSearch);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void BinarySearch_WithRange_ShouldThrowArgumentOutOfRangeException_WhenIndexOutOfRange()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int valueToSearch = 7;
            int index = -1;
            int length = 3;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => array.BinarySearch(index, length, valueToSearch));
        }

        [Fact]
        public void BinarySearch_WithRange_ShouldThrowArgumentOutOfRangeException_WhenLengthOutOfRange()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            int valueToSearch = 7;
            int index = 1;
            int length = 10;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => array.BinarySearch(index, length, valueToSearch));
        }

        //[Fact]
        //public void BinarySearch_WithComparer_ShouldReturnIndex_WhenValueExists()
        //{
        //    // Arrange
        //    string[] array = { "apple", "banana", "cherry" };
        //    string valueToSearch = "banana";
        //    IComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    // Act
        //    int result = array.BinarySearch(valueToSearch, comparer);

        //    // Assert
        //    Assert.Equal(1, result);
        //}

        //[Fact]
        //public void BinarySearch_WithComparer_ShouldReturnNegative_WhenValueDoesNotExist()
        //{
        //    // Arrange
        //    string[] array = { "apple", "banana", "cherry" };
        //    string valueToSearch = "grape";
        //    IComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    // Act
        //    int result = array.BinarySearch(valueToSearch, comparer);

        //    // Assert
        //    Assert.True(result < 0);
        //}

        //[Fact]
        //public void BinarySearch_WithRangeAndComparer_ShouldReturnIndex_WhenValueExists()
        //{
        //    // Arrange
        //    string[] array = { "apple", "banana", "cherry", "date" };
        //    string valueToSearch = "cherry";
        //    int index = 1;
        //    int length = 2;
        //    IComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    // Act
        //    int result = array.BinarySearch(index, length, valueToSearch, comparer);

        //    // Assert
        //    Assert.Equal(2, result);
        //}

        //[Fact]
        //public void BinarySearch_WithRangeAndComparer_ShouldThrowArgumentNullException_WhenArrayIsNull()
        //{
        //    // Arrange
        //    string[] array = null;
        //    string valueToSearch = "cherry";
        //    int index = 0;
        //    int length = 1;
        //    IComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    // Act & Assert
        //    Assert.Throws<ArgumentNullException>(() => array.BinarySearch(index, length, valueToSearch, comparer));
        //}
    }
}
