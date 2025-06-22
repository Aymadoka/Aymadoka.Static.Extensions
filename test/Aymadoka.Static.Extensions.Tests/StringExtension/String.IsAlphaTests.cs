namespace Aymadoka.Static.StringExtension
{
    public class String_IsAlphaTests
    {
        [Theory]
        [InlineData("abc", true)]
        [InlineData("ABC", true)]
        [InlineData("AbC", true)]
        [InlineData("abc123", false)]
        [InlineData("123", false)]
        [InlineData("abc!", false)]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("abc def", false)]
        [InlineData("äbc", false)]
        public void IsAlpha_ReturnsExpectedResult(string input, bool expected)
        {
            var result = input.IsAlpha();
            Assert.Equal(expected, result);
        }
    }
}
