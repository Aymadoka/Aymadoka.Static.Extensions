namespace Aymadoka.Static.StringExtension
{
    public class String_IsAlphaNumericTests
    {
        [Theory]
        [InlineData("abc123", true)]
        [InlineData("ABC", true)]
        [InlineData("123", true)]
        [InlineData("abcABC123", true)]
        [InlineData("abc_123", false)]
        [InlineData("abc-123", false)]
        [InlineData("abc 123", false)]
        [InlineData("!@#", false)]
        [InlineData("", true)]
        [InlineData(null, false)]
        public void IsAlphaNumeric_ReturnsExpectedResult(string input, bool expected)
        {
            bool result = input != null && input.IsAlphaNumeric();
            Assert.Equal(expected, result);
        }
    }
}
