namespace Aymadoka.Static.StringExtension
{
    public class String_RemoveLetterTests
    {
        [Theory]
        [InlineData("abc123", "123")]
        [InlineData("Hello, 世界123!", ", 123!")]
        [InlineData("123456", "123456")]
        [InlineData("!@#$%^", "!@#$%^")]
        [InlineData("中文English123", "123")]
        [InlineData("", "")]
        public void RemoveLetter_RemovesAllUnicodeLetters(string input, string expected)
        {
            var result = input.RemoveLetter();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveLetter_NullInput_ThrowsArgumentNullException()
        {
            string input = null;
            Assert.Throws<ArgumentNullException>(() => input.RemoveLetter());
        }
    }
}
