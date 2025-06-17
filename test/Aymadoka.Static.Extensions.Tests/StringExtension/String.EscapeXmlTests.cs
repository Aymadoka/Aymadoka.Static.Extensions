namespace Aymadoka.Static.StringExtension
{
    public class String_EscapeXmlTests
    {
        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("&", "&amp;")]
        [InlineData("<", "&lt;")]
        [InlineData(">", "&gt;")]
        [InlineData("\"", "&quot;")]
        [InlineData("'", "&apos;")]
        [InlineData("a&b<c>d\"e'f", "a&amp;b&lt;c&gt;d&quot;e&apos;f")]
        [InlineData("&<>'\"", "&amp;&lt;&gt;&apos;&quot;")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void EscapeXml_ShouldEscapeSpecialXmlCharacters(string input, string expected)
        {
            var result = input?.EscapeXml();
            Assert.Equal(expected, result);
        }
    }
}
