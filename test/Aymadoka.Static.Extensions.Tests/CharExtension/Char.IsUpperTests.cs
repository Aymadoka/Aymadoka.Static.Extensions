namespace Aymadoka.Static.CharExtension
{
    public class Char_IsUpperTests
    {
        [Theory]
        [InlineData('A', true)]
        [InlineData('Z', true)]
        [InlineData('a', false)]
        [InlineData('z', false)]
        [InlineData('0', false)]
        [InlineData(' ', false)]
        [InlineData('中', false)]
        public void IsUpper_ReturnsExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsUpper();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
