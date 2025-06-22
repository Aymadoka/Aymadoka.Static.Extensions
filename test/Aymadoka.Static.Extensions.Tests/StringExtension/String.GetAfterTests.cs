namespace Aymadoka.Static.StringExtension
{
    public class String_GetAfterTests
    {
        [Theory]
        [InlineData("hello world", "hello", " world")]
        [InlineData("abcabcabc", "bca", "bcabc")]
        [InlineData("test", "notfound", "")]
        [InlineData("prefix_suffix", "prefix_", "suffix")]
        [InlineData("value", "value", "")]
        [InlineData("", "a", "")]
        [InlineData("abc", "", "abc")]
        public void GetAfter_ReturnsExpectedResult(string input, string value, string expected)
        {
            var result = input.GetAfter(value);
            Assert.Equal(expected, result);
        }
    }
}
