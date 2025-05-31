using System.Globalization;
using System;

namespace Aymadoka.Static.CharExtension
{
    public class Char_ToLowerTests
    {
        [Theory]
        [InlineData('A', 'a')]
        [InlineData('Z', 'z')]
        [InlineData('a', 'a')]
        [InlineData('1', '1')]
        [InlineData('Ç', 'ç')]
        public void ToLower_DefaultCulture_ReturnsExpected(char input, char expected)
        {
            var result = input.ToLower();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData('I', "tr-TR", 'ı')] // Turkish I
        [InlineData('İ', "tr-TR", 'i')] // Turkish İ
        [InlineData('A', "en-US", 'a')]
        [InlineData('A', "fr-FR", 'a')]
        public void ToLower_WithCulture_ReturnsExpected(char input, string cultureName, char expected)
        {
            var culture = new CultureInfo(cultureName);
            var result = input.ToLower(culture);
            Assert.Equal(expected, result);
        }
    }
}
