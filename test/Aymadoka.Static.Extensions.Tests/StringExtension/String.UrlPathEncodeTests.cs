namespace Aymadoka.Static.StringExtension
{
    public class String_UrlPathEncodeTests
    {
        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("a b", "a%20b")]
        [InlineData("a/b", "a/b")]
        [InlineData("a?b", "a?b")]
        [InlineData("a#b", "a#b")]
        [InlineData("a+b", "a+b")]
        [InlineData("你好", "%e4%bd%a0%e5%a5%bd")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void UrlPathEncode_ReturnsExpectedResult(string input, string expected)
        {
            var result = input.UrlPathEncode();
            Assert.Equal(expected, result);
        }
    }
}
