using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public class String_IsMatchTests
    {
        [Theory]
        [InlineData("abc123", @"\d+", true)]
        [InlineData("abcdef", @"\d+", false)]
        [InlineData("Hello World", @"^Hello", true)]
        [InlineData("Hello World", @"world$", false)]
        public void IsMatch_WithPattern_ReturnsExpected(string input, string pattern, bool expected)
        {
            var result = input.IsMatch(pattern);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcDEF", @"def$", false, RegexOptions.None)]
        [InlineData("abcDEF", @"def$", true, RegexOptions.IgnoreCase)]
        [InlineData("123-456", @"\d{3}-\d{3}", true, RegexOptions.None)]
        [InlineData("abc", @"[A-Z]+", false, RegexOptions.None)]
        [InlineData("abc", @"[A-Z]+", true, RegexOptions.IgnoreCase)]
        public void IsMatch_WithPatternAndOptions_ReturnsExpected(string input, string pattern, bool expected, RegexOptions options)
        {
            var result = input.IsMatch(pattern, options);
            Assert.Equal(expected, result);
        }
    }
}
