using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_UrlDecodeTests
    {
        [Theory]
        [InlineData("hello%20world", "hello world")]
        [InlineData("C%23%20is%20awesome%21", "C# is awesome!")]
        [InlineData("%E4%BD%A0%E5%A5%BD", "你好")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void UrlDecode_DefaultEncoding_Works(string input, string expected)
        {
            var result = input.UrlDecode();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UrlDecode_WithEncoding_Works()
        {
            // "你好" encoded in UTF-8: %E4%BD%A0%E5%A5%BD
            string encoded = "%E4%BD%A0%E5%A5%BD";
            string expected = "你好";
            var result = encoded.UrlDecode(Encoding.UTF8);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UrlDecode_WithEncoding_NullInput_ReturnsNull()
        {
            string input = null;
            var result = input.UrlDecode(Encoding.UTF8);
            Assert.Null(result);
        }
    }
}
