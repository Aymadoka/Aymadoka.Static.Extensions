namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ClearAtTests
    {
        [Fact]
        public void ClearAt_ShouldSetElementToDefault_WhenIndexIsValid()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = 2;

            // Act
            array.ClearAt(index);

            // Assert
            Assert.Equal(new[] { 1, 2, 0, 4, 5 }, array);
        }

        [Fact]
        public void ClearAt_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[] array = null;
            int index = 0;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.ClearAt(index));
        }

        [Fact]
        public void ClearAt_ShouldThrowIndexOutOfRangeException_WhenIndexIsNegative()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = -1;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.ClearAt(index));
        }

        [Fact]
        public void ClearAt_ShouldThrowIndexOutOfRangeException_WhenIndexIsOutOfBounds()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = 5; // Out of bounds

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => array.ClearAt(index));
        }

        [Fact]
        public void ClearAt_ShouldWorkForReferenceTypeArray()
        {
            // Arrange
            string[] array = { "a", "b", "c", "d" };
            int index = 1;

            // Act
            array.ClearAt(index);

            // Assert
            Assert.Equal(new[] { "a", null, "c", "d" }, array);
        }
    }
}
