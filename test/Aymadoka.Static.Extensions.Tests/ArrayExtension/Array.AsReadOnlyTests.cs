using System.Collections.ObjectModel;

namespace Aymadoka.Static.ArrayExtension
{
    public class Array_AsReadOnlyTests
    {
        [Fact]
        public void AsReadOnly_ShouldReturnReadOnlyCollection_WhenArrayIsNotNull()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act
            ReadOnlyCollection<int> readOnlyCollection = array.AsReadOnly();

            // Assert
            Assert.NotNull(readOnlyCollection);
            Assert.Equal(array.Length, readOnlyCollection.Count);
            Assert.Equal(array, readOnlyCollection);
        }

        [Fact]
        public void AsReadOnly_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[]? array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array!.AsReadOnly());
        }

        [Fact]
        public void AsReadOnly_ShouldReturnEmptyReadOnlyCollection_WhenArrayIsEmpty()
        {
            // Arrange
            int[] array = Array.Empty<int>();

            // Act
            ReadOnlyCollection<int> readOnlyCollection = array.AsReadOnly();

            // Assert
            Assert.NotNull(readOnlyCollection);
            Assert.Empty(readOnlyCollection);
        }

        [Fact]
        public void AsReadOnly_ShouldReflectChangesInOriginalArray()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act
            ReadOnlyCollection<int> readOnlyCollection = array.AsReadOnly();
            array[0] = 42;

            // Assert
            Assert.Equal(42, readOnlyCollection[0]);
        }
    }
}
