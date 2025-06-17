namespace Aymadoka.Static.StringExtension
{
    public class String_NullIfEmptyTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData(" ", " ")]
        [InlineData("abc", "abc")]
        public void NullIfEmpty_ReturnsExpectedResult(string? input, string? expected)
        {
            var result = input.NullIfEmpty();
            Assert.Equal(expected, result);
        }
    }
}
