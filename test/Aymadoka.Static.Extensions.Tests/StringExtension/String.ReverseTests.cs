namespace Aymadoka.Static.StringExtension
{
    public class String_ReverseTests
    {
        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("Aymadoka", "akodamyA")]
        [InlineData("12345", "54321")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData("  ", "  ")]
        [InlineData(null, null)]
        public void Reverse_ReturnsExpectedResult(string input, string expected)
        {
            var result = input.Reverse();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Reverse_WhiteSpaceString_ReturnsOriginal()
        {
            string input = "   ";
            var result = input.Reverse();
            Assert.Equal(input, result);
        }
    }
}
