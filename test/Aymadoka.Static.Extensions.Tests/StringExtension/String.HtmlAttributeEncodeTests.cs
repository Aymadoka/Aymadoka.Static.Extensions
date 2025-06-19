using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_HtmlAttributeEncodeTests
    {
        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("<div>", "&lt;div>")]
        [InlineData("\"quote\"", "&quot;quote&quot;")]
        [InlineData("a&b", "a&amp;b")]
        [InlineData("a'b", "a&#39;b")]
        [InlineData(null, null)]
        public void HtmlAttributeEncode_ReturnsExpectedResult(string input, string expected)
        {
            var result = input.HtmlAttributeEncode();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("<div>", "&lt;div>")]
        [InlineData("\"quote\"", "&quot;quote&quot;")]
        [InlineData("a&b", "a&amp;b")]
        [InlineData("a'b", "a&#39;b")]
        [InlineData(null, "")]
        public void HtmlAttributeEncode_WritesToTextWriter(string input, string expected)
        {
            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);
            input.HtmlAttributeEncode(writer);
            Assert.Equal(expected, sb.ToString());
        }
    }
}
