using System.Collections.Specialized;
using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_ParseQueryStringTests
    {
        [Fact]
        public void ParseQueryString_ShouldParseSimpleQuery()
        {
            string query = "a=1&b=2";
            NameValueCollection result = query.ParseQueryString();

            Assert.Equal("1", result["a"]);
            Assert.Equal("2", result["b"]);
        }

        [Fact]
        public void ParseQueryString_ShouldHandleEmptyQuery()
        {
            string query = "";
            NameValueCollection result = query.ParseQueryString();

            Assert.Empty(result);
        }

        [Fact]
        public void ParseQueryString_ShouldHandleNullValue()
        {
            string query = "a=1&b=";
            NameValueCollection result = query.ParseQueryString();

            Assert.Equal("1", result["a"]);
            Assert.Equal(string.Empty, result["b"]);
        }

        [Fact]
        public void ParseQueryString_WithEncoding_ShouldParseEncodedQuery()
        {
            string query = "name=%E5%BC%A0%E4%B8%89"; // "name=张三" in UTF-8
            NameValueCollection result = query.ParseQueryString(Encoding.UTF8);

            Assert.Equal("张三", result["name"]);
        }
    }
}
