namespace Aymadoka.Static.CharExtension
{
    public class Char_ToStringTests
    {
        [Theory]
        [InlineData('a', "a")]
        [InlineData('Z', "Z")]
        [InlineData('0', "0")]
        [InlineData(' ', " ")]
        [InlineData('\n', "\n")]
        public void ToString_ReturnsExpectedString(char input, string expected)
        {
            // Act
            var result = input.ToString();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
