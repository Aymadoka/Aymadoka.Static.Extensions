namespace Aymadoka.Static.StringExtension
{
    public class String_RightTests
    {
        [Theory]
        [InlineData("abcdef", 3, "def")]
        [InlineData("abcdef", 0, "")]
        [InlineData("abcdef", -1, "")]
        [InlineData("abcdef", 6, "abcdef")]
        [InlineData("abcdef", 10, "abcdef")]
        [InlineData("", 2, "")]
        [InlineData(null, 2, "")]
        public void Right_ReturnsExpectedResult(string input, int length, string expected)
        {
            var result = input.Right(length);
            Assert.Equal(expected, result);
        }
    }
}
