namespace Aymadoka.Static.CharExtension
{
    public class Char_ToUpperInvariantTests
    {
        [Theory]
        [InlineData('a', 'A')]
        [InlineData('z', 'Z')]
        [InlineData('A', 'A')]
        [InlineData('Z', 'Z')]
        [InlineData('1', '1')]
        [InlineData(' ', ' ')]
        [InlineData('é', 'É')]
        public void ToUpperInvariant_ReturnsExpectedResult(char input, char expected)
        {
            // Act
            var result = input.ToUpperInvariant();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
