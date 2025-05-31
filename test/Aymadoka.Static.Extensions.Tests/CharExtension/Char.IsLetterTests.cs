using System;

namespace Aymadoka.Static.CharExtension
{
    public class Char_IsLetterTests
    {
        [Theory]
        [InlineData('a', true)]
        [InlineData('Z', true)]
        [InlineData('中', true)]
        [InlineData('1', false)]
        [InlineData('!', false)]
        [InlineData(' ', false)]
        [InlineData('\n', false)]
        public void IsLetter_ReturnsExpectedResult(char input, bool expected)
        {
            // Act
            var result = input.IsLetter();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
