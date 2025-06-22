namespace Aymadoka.Static.StringExtension
{
    public class String_LeftTests
    {
        [Theory]
        [InlineData("abcdef", 3, "abc")]
        [InlineData("abcdef", 0, "")]
        [InlineData("abcdef", -1, "")]
        [InlineData("abcdef", 6, "abcdef")]
        [InlineData("abcdef", 10, "abcdef")]
        [InlineData("", 3, "")]
        [InlineData(null, 3, "")]
        public void Left_ReturnsExpectedResult(string? input, int length, string expected)
        {
            var result = input.Left(length);
            Assert.Equal(expected, result);
        }
    }
}
