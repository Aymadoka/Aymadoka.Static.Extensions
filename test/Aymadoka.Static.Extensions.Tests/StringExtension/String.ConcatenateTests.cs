namespace Aymadoka.Static.StringExtension
{
    public class String_ConcatenateTests
    {
        [Fact]
        public void Concatenate_StringEnumerable_ReturnsConcatenatedString()
        {
            // Arrange
            var strings = new List<string> { "Hello", " ", "World", "!" };

            // Act
            var result = strings.Concatenate();

            // Assert
            Assert.Equal("Hello World!", result);
        }

        [Fact]
        public void Concatenate_EmptyStringEnumerable_ReturnsEmptyString()
        {
            // Arrange
            var strings = new List<string>();

            // Act
            var result = strings.Concatenate();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Concatenate_GenericEnumerableWithFunc_ReturnsConcatenatedString()
        {
            // Arrange
            var numbers = new List<int> { 1, 2, 3 };

            // Act
            var result = numbers.Concatenate(n => n.ToString());

            // Assert
            Assert.Equal("123", result);
        }

        [Fact]
        public void Concatenate_GenericEnumerableWithFunc_EmptySource_ReturnsEmptyString()
        {
            // Arrange
            var numbers = new List<int>();

            // Act
            var result = numbers.Concatenate(n => n.ToString());

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Concatenate_StringEnumerable_WithNullElements_TreatsNullAsEmpty()
        {
            // Arrange
            var strings = new List<string> { "A", null, "B" };

            // Act
            var result = strings.Concatenate();

            // Assert
            Assert.Equal("AB", result);
        }

        [Fact]
        public void Concatenate_GenericEnumerableWithFunc_FuncReturnsNull_TreatsNullAsEmpty()
        {
            // Arrange
            var items = new List<int> { 1, 2 };

            // Act
            var result = items.Concatenate(i => i == 2 ? null : "X");

            // Assert
            Assert.Equal("X", result);
        }
    }
}
