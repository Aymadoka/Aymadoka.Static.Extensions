namespace Aymadoka.Static.CharExtension
{
    public class Char_IsSymbolTests
    {
        [Theory]
        [InlineData('+', true)]
        [InlineData('=', true)]
        [InlineData('$', true)]
        [InlineData('©', true)]
        [InlineData('a', false)]
        [InlineData('1', false)]
        [InlineData(' ', false)]
        [InlineData('\n', false)]
        public void IsSymbol_ReturnsExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsSymbol();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
