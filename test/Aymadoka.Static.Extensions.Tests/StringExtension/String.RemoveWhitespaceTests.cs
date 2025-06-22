namespace Aymadoka.Static.StringExtension
{
    public class String_RemoveWhitespaceTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData("abc", "abc")]
        [InlineData(" a b c ", "abc")]
        [InlineData("a\tb\nc", "abc")]
        [InlineData("  a  b  c  ", "abc")]
        [InlineData("a　b　c", "abc")] // 包含全角空格
        public void RemoveWhitespace_RemovesAllWhitespace(string input, string expected)
        {
            var result = input.RemoveWhitespace();
            Assert.Equal(expected, result);
        }
    }
}
