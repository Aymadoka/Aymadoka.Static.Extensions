namespace Aymadoka.Static.CharExtension
{
    public class Char_IsLetterOrDigitTests
    {
        [Theory]
        [InlineData('a', true)]
        [InlineData('Z', true)]
        [InlineData('0', true)]
        [InlineData('9', true)]
        [InlineData('-', false)]
        [InlineData(' ', false)]
        [InlineData('@', false)]
        [InlineData('中', true)]
        public void IsLetterOrDigit_ReturnsExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsLetterOrDigit();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
