namespace Aymadoka.Static.CharExtension
{
    public class Char_IsNumberTests
    {
        [Theory]
        [InlineData('0', true)]
        [InlineData('5', true)]
        [InlineData('9', true)]
        [InlineData('a', false)]
        [InlineData('Z', false)]
        [InlineData('-', false)]
        [InlineData(' ', false)]
        [InlineData('\n', false)]
        [InlineData('Ⅷ', true)] // 罗马数字
        [InlineData('²', true)] // 上标数字
        public void IsNumber_ReturnsExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsNumber();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
