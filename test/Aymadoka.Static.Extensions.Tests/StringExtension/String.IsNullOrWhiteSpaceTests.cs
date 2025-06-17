namespace Aymadoka.Static.StringExtension
{
    public class String_IsNullOrWhiteSpaceTests
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("   ", true)]
        [InlineData("\t\r\n", true)]
        [InlineData("abc", false)]
        [InlineData(" abc ", false)]
        public void IsNullOrWhiteSpace_ReturnsExpectedResult(string? input, bool expected)
        {
            var result = StringExtensions.IsNullOrWhiteSpace(input);
            Assert.Equal(expected, result);
        }
    }
}
