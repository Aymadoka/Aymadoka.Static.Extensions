namespace Aymadoka.Static.CharExtension
{
    public class Char_IsDigitTests
    {
        [Theory]
        [InlineData('0', true)]
        [InlineData('1', true)]
        [InlineData('5', true)]
        [InlineData('9', true)]
        [InlineData('a', false)]
        [InlineData('Z', false)]
        [InlineData('-', false)]
        [InlineData(' ', false)]
        [InlineData('\n', false)]
        [InlineData('中', false)]
        [InlineData('\u0660', true)] // 阿拉伯-印度数字0
        [InlineData('\u0966', true)] // 天城文数字0
        public void IsDigit_ShouldReturnExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsDigit();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
