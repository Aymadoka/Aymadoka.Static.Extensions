namespace Aymadoka.Static.CharExtension
{
    public class Char_IsPunctuationTests
    {
        [Theory]
        [InlineData('.', true)]
        [InlineData(',', true)]
        [InlineData('!', true)]
        [InlineData('?', true)]
        [InlineData(';', true)]
        [InlineData(':', true)]
        [InlineData('a', false)]
        [InlineData('1', false)]
        [InlineData(' ', false)]
        [InlineData('\n', false)]
        public void IsPunctuation_ReturnsExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsPunctuation();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
