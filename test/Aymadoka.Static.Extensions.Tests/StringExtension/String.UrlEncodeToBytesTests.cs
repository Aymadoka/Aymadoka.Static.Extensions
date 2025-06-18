using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_UrlEncodeToBytesTests
    {
        [Theory]
        [InlineData("hello world", "hello+world")]
        [InlineData("测试", "%E6%B5%8B%E8%AF%95")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void UrlEncodeToBytes_DefaultEncoding_ReturnsExpectedBytes(string input, string expectedEncoded)
        {
            var expected = expectedEncoded == null ? null : Encoding.UTF8.GetBytes(expectedEncoded);
            var result = input.UrlEncodeToBytes();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("hello world", "hello+world")]
        [InlineData("测试", "%B2%E2%CA%D4")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void UrlEncodeToBytes_SpecifiedEncoding_ReturnsExpectedBytes(string input, string expectedEncoded)
        {
            var encoding = Encoding.GetEncoding("GB2312");
            var expected = expectedEncoded == null ? null : encoding.GetBytes(expectedEncoded);
            var result = input.UrlEncodeToBytes(encoding);
            Assert.Equal(expected, result);
        }
    }
}
