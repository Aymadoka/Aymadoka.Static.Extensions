namespace Aymadoka.Static.StringExtension
{
    public class String_ExtractLetterTests
    {
        [Theory]
        [InlineData("abc123", "abc")]
        [InlineData("A1B2C3", "ABC")]
        [InlineData("!@#abcDEF", "abcDEF")]
        [InlineData("123456", "")]
        [InlineData("", "")]
        [InlineData("中文abc", "中文abc")]
        [InlineData("a b c", "abc")]
        [InlineData("A_B-C", "ABC")]
        public void ExtractLetter_ReturnsOnlyLetters(string input, string expected)
        {
            var result = input.ExtractLetter();
            Assert.Equal(expected, result);
        }
    }
}
