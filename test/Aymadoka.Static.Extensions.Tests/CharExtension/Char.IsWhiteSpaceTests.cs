namespace Aymadoka.Static.CharExtension
{
    public class Char_IsWhiteSpaceTests
    {
        [Theory]
        [InlineData(' ', true)]
        [InlineData('\t', true)]
        [InlineData('\n', true)]
        [InlineData('\r', true)]
        [InlineData('\u00A0', true)] // 不间断空格
        [InlineData('a', false)]
        [InlineData('1', false)]
        [InlineData('-', false)]
        public void IsWhiteSpace_ReturnsExpected(char input, bool expected)
        {
            // Act
            var result = input.IsWhiteSpace();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
