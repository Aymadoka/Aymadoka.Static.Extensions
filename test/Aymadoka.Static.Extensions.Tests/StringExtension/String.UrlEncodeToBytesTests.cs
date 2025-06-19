using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_UrlEncodeToBytesTests
    {
        [Theory]
        [InlineData("hello world", "hello+world")]
        [InlineData("测试", "%e6%b5%8b%e8%af%95")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void UrlEncodeToBytes_DefaultEncoding_ReturnsExpectedBytes(string input, string expectedEncoded)
        {
            var expected = expectedEncoded == null ? null : Encoding.UTF8.GetBytes(expectedEncoded);
            var result = input.UrlEncodeToBytes();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UrlEncodeToBytes_WithEncoding_ReturnsExpectedBytes()
        {
            // Arrange
            string input = "测试 test 123 !@#";
            Encoding encoding = Encoding.Unicode;
            byte[] expected = System.Web.HttpUtility.UrlEncodeToBytes(input, encoding);

            // Act
            byte[] actual = input.UrlEncodeToBytes(encoding);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
