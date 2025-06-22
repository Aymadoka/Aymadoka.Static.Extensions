using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_HtmlEncodeTests
    {
        [Theory]
        [InlineData("<div>", "&lt;div&gt;")]
        [InlineData("\"Hello\"", "&quot;Hello&quot;")]
        [InlineData("A&B", "A&amp;B")]
        [InlineData("NoSpecialChars", "NoSpecialChars")]
        [InlineData(null, null)]
        public void HtmlEncode_ReturnsExpectedResult(string input, string expected)
        {
            var result = input.HtmlEncode();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("<div>", "&lt;div&gt;")]
        [InlineData("A&B", "A&amp;B")]
        [InlineData(null, "")]
        public void HtmlEncode_WithTextWriter_WritesExpectedResult(string input, string expected)
        {
            var sb = new StringBuilder();
            using (var writer = new StringWriter(sb))
            {
                input.HtmlEncode(writer);
            }

            Assert.Equal(expected, sb.ToString());
        }
    }
}
