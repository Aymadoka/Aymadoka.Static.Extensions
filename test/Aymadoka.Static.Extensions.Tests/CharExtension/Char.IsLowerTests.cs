namespace Aymadoka.Static.CharExtension
{
    public class Char_IsLowerTests
    {
        [Theory]
        [InlineData('a', true)]
        [InlineData('z', true)]
        [InlineData('A', false)]
        [InlineData('Z', false)]
        [InlineData('0', false)]
        [InlineData(' ', false)]
        [InlineData('中', false)]
        [InlineData('é', true)]
        public void IsLower_ReturnsExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsLower();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
