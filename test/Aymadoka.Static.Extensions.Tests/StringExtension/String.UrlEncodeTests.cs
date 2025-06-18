using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_UrlEncodeTests
    {
        [Theory]
        [InlineData("hello world", "hello+world")]
        [InlineData("a+b", "a%2bb")]
        [InlineData("中文", "%E4%B8%AD%E6%96%87")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void UrlEncode_DefaultEncoding_Works(string input, string expected)
        {
            var result = input.UrlEncode();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UrlEncode_WithEncoding_Works()
        {
            string input = "中文";
            Encoding encoding = Encoding.UTF8;
            string expected = "%E4%B8%AD%E6%96%87";
            var result = input.UrlEncode(encoding);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UrlEncode_WithEncoding_NullInput_ReturnsNull()
        {
            string input = null;
            Encoding encoding = Encoding.UTF8;
            var result = input.UrlEncode(encoding);
            Assert.Null(result);
        }
    }
}
