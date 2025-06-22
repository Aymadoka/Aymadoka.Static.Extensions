namespace Aymadoka.Static.StringExtension
{
    public class String_RemoveNumberTests
    {
        [Theory]
        [InlineData("abc123", "abc")]
        [InlineData("1a2b3c", "abc")]
        [InlineData("123456", "")]
        [InlineData("abcdef", "abcdef")]
        [InlineData("", "")]
        [InlineData("a1b2c3d4e5", "abcde")]
        [InlineData("测试123", "测试")]
        [InlineData("１２３abc", "abc")] // 全角数字
        public void RemoveNumber_RemovesAllNumbers(string input, string expected)
        {
            var result = input.RemoveNumber();
            Assert.Equal(expected, result);
        }
    }
}
