namespace Aymadoka.Static.StringExtension
{
    public class String_IfEmptyTests
    {
        [Theory]
        [InlineData("", "default", "default")]
        [InlineData(" ", "default", " ")]
        [InlineData("abc", "default", "abc")]
        public void IfEmpty_ReturnsExpectedResult(string input, string defaultValue, string expected)
        {
            var result = input.IfEmpty(defaultValue);
            Assert.Equal(expected, result);
        }
    }
}
