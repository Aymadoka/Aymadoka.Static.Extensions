namespace Aymadoka.Static.StringExtension
{
    public class String_IsNumericTests
    {
        [Theory]
        [InlineData("123456", true)]
        [InlineData("0", true)]
        [InlineData("00123", true)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("123abc", false)]
        [InlineData("abc123", false)]
        [InlineData("12 34", false)]
        [InlineData("12.34", false)]
        [InlineData("-123", false)]
        [InlineData("+123", false)]
        public void IsNumeric_ReturnsExpectedResult(string input, bool expected)
        {
            var result = input.IsNumeric();
            Assert.Equal(expected, result);
        }
    }
}
