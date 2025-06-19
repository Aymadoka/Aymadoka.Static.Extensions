using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_HtmlDecodeTests
    {
        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("&lt;div&gt;", "<div>")]
        [InlineData("&amp;#39;", "&#39;")]
        [InlineData("A &amp; B", "A & B")]
        [InlineData(null, null)]
        public void HtmlDecode_ReturnsExpectedResult(string input, string expected)
        {
            var result = input.HtmlDecode();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("&lt;span&gt;Test&lt;/span&gt;", "<span>Test</span>")]
        [InlineData("&quot;Hello&quot;", "\"Hello\"")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void HtmlDecode_WithTextWriter_WritesExpectedResult(string input, string expected)
        {
            var sb = new StringBuilder();
            using var writer = new StringWriter(sb);
            input.HtmlDecode(writer);
            Assert.Equal(expected, sb.ToString());
        }
    }
}
