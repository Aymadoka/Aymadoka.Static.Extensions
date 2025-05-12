namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ClearTests
    {
        [Fact]
        public void Clear_ShouldSetElementsToDefault_WhenParametersAreValid()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = 1;
            int length = 3;

            // Act
            array.Clear(index, length);

            // Assert
            Assert.Equal(new[] { 1, 0, 0, 0, 5 }, array);
        }

        [Fact]
        public void Clear_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] array = null;
            int index = 0;
            int length = 1;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.Clear(index, length));
        }

        [Fact]
        public void Clear_ShouldThrowIndexOutOfRangeException_WhenIndexIsOutOfRange()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = -1; // Invalid index
            int length = 2;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.Clear(index, length));
        }

        [Fact]
        public void Clear_ShouldThrowIndexOutOfRangeException_WhenLengthIsOutOfRange()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = 3;
            int length = 5; // Exceeds array bounds

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.Clear(index, length));
        }

        [Fact]
        public void Clear_ShouldNotModifyArray_WhenLengthIsZero()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = 2;
            int length = 0;

            // Act
            array.Clear(index, length);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, array);
        }

        [Fact]
        public void Clear_ShouldWorkForReferenceTypeArray()
        {
            // Arrange
            string[] array = { "a", "b", "c", "d", "e" };
            int index = 1;
            int length = 2;

            // Act
            array.Clear(index, length);

            // Assert
            Assert.Equal(new[] { "a", null, null, "d", "e" }, array);
        }
    }
}
