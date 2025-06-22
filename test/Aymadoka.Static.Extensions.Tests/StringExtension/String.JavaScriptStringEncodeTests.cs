namespace Aymadoka.Static.StringExtension
{
    public class String_JavaScriptStringEncodeTests
    {
        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("'", "\\u0027")]
        [InlineData("\\", "\\\\")]
        [InlineData("\n", "\\n")]
        [InlineData("\r", "\\r")]
        [InlineData("\t", "\\t")]
        [InlineData("<script>", "\\u003cscript\\u003e")]
        [InlineData(null, "")]
        public void JavaScriptStringEncode_WithoutDoubleQuotes_ReturnsExpected(string input, string expected)
        {
            var result = input.JavaScriptStringEncode();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("\"", "\"\\\"\"")]
        [InlineData("'", "\"\\u0027\"")]
        [InlineData("abc", "\"abc\"")]
        [InlineData("\\", "\"\\\\\"")]
        [InlineData("\n", "\"\\n\"")]
        [InlineData("\r", "\"\\r\"")]
        [InlineData("\t", "\"\\t\"")]
        [InlineData("<script>", "\"\\u003cscript\\u003e\"")]
        [InlineData("", "\"\"")]
        public void JavaScriptStringEncode_WithDoubleQuotes_ReturnsExpected(string input, string expected)
        {
            var result = input.JavaScriptStringEncode(true);
            Assert.Equal(expected, result);
        }
    }
}
