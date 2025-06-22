namespace Aymadoka.Static.StringExtension
{
    public class String_TruncateTests
    {
        [Theory]
        [InlineData(null, 5, "")]
        [InlineData("", 5, "")]
        [InlineData("abc", 5, "abc")]
        [InlineData("abcdef", 6, "abcdef")]
        [InlineData("abcdef", 5, "ab...")]
        [InlineData("abcdef", 3, "...")]
        [InlineData("abcdef", 2, "..")]
        [InlineData("abcdef", 0, "")]
        public void Truncate_DefaultSuffix_Works(string input, int maxLength, string expected)
        {
            var result = input.Truncate(maxLength);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, 5, "***", "")]
        [InlineData("", 5, "***", "")]
        [InlineData("abc", 5, "***", "abc")]
        [InlineData("abcdef", 6, "***", "abcdef")]
        [InlineData("abcdef", 5, "***", "ab***")]
        [InlineData("abcdef", 3, "***", "***")]
        [InlineData("abcdef", 2, "***", "**")]
        [InlineData("abcdef", 0, "***", "")]
        [InlineData("abcdef", 5, "", "abcde")]
        public void Truncate_CustomSuffix_Works(string input, int maxLength, string suffix, string expected)
        {
            var result = input.Truncate(maxLength, suffix);
            Assert.Equal(expected, result);
        }
    }
}
