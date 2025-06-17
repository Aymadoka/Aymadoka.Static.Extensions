namespace Aymadoka.Static.StringExtension
{
    public class String_RemoveLetterTests
    {
        [Theory]
        [InlineData("abc123", "123")]
        [InlineData("Hello, 世界!", ", 世界!")]
        [InlineData("123456", "123456")]
        [InlineData("A1B2C3", "123")]
        [InlineData("", "")]
        [InlineData("!@#$%", "!@#$%")]
        [InlineData("中文English混合", "中文混合")]
        public void RemoveLetter_RemovesAllLetters(string input, string expected)
        {
            var result = input.RemoveLetter();
            Assert.Equal(expected, result);
        }
    }
}
