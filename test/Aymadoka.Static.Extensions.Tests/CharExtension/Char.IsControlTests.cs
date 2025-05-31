using System;

namespace Aymadoka.Static.CharExtension
{
    public class Char_IsControlTests
    {
        [Theory]
        [InlineData('\u0000', true)]  // Null char, control
        [InlineData('\u0009', true)]  // Tab, control
        [InlineData('\u001F', true)]  // Unit Separator, control
        [InlineData('\u007F', true)]  // Delete, control
        [InlineData('A', false)]      // Letter, not control
        [InlineData('1', false)]      // Digit, not control
        [InlineData(' ', false)]      // Space, not control
        [InlineData('\u0085', true)]  // Next Line, control
        [InlineData('\u200B', false)] // Zero width space, not control
        public void IsControl_ReturnsExpected(char input, bool expected)
        {
            // Act
            var result = input.IsControl();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
