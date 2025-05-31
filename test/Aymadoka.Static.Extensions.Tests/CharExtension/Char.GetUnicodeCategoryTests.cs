using System.Globalization;

namespace Aymadoka.Static.CharExtension
{
    public class Char_GetUnicodeCategoryTests
    {
        [Theory]
        [InlineData('A', UnicodeCategory.UppercaseLetter)]
        [InlineData('a', UnicodeCategory.LowercaseLetter)]
        [InlineData('1', UnicodeCategory.DecimalDigitNumber)]
        [InlineData(' ', UnicodeCategory.SpaceSeparator)]
        [InlineData('\n', UnicodeCategory.Control)]
        [InlineData('中', UnicodeCategory.OtherLetter)]
        public void GetUnicodeCategory_ReturnsExpectedCategory(char input, UnicodeCategory expected)
        {
            // Act
            var result = input.GetUnicodeCategory();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
