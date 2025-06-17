namespace Aymadoka.Static.StringExtension
{
    public class String_IsNotNullOrWhiteSpaceTests
    {
        [Theory]
        [InlineData("hello", true)]
        [InlineData("  hello  ", true)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsNotNullOrWhiteSpace_ReturnsExpectedResult(string? input, bool expected)
        {
            var result = input.IsNotNullOrWhiteSpace();
            Assert.Equal(expected, result);
        }
    }
}
