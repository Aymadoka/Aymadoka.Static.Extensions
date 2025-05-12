namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ClearAllTests
    {
        [Fact]
        public void ClearAll_ShouldSetAllElementsToDefault_WhenArrayIsValid()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            array.ClearAll();

            // Assert
            Assert.Equal(new[] { 0, 0, 0, 0, 0 }, array);
        }

        [Fact]
        public void ClearAll_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.ClearAll());
        }

        [Fact]
        public void ClearAll_ShouldNotThrowException_WhenArrayIsEmpty()
        {
            // Arrange
            int[] array = Array.Empty<int>();

            // Act
            array.ClearAll();

            // Assert
            Assert.Empty(array); // Array remains empty
        }

        [Fact]
        public void ClearAll_ShouldWorkForReferenceTypeArray()
        {
            // Arrange
            string[] array = { "a", "b", "c" };

            // Act
            array.ClearAll();

            // Assert
            Assert.Equal(new string[] { null, null, null }, array);
        }

        [Fact]
        public void ClearAll_ShouldWorkForMixedValuesInArray()
        {
            // Arrange
            object[] array = { 1, "test", null, 3.14 };

            // Act
            array.ClearAll();

            // Assert
            Assert.Equal(new object[] { null, null, null, null }, array);
        }
    }
}
