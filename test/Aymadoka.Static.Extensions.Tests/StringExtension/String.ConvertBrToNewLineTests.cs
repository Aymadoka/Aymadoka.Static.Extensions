namespace Aymadoka.Static.StringExtension
{
    public class String_ConvertBrToNewLineTests
    {
        [Theory]
        [InlineData("Hello<br />World", "Hello\r\nWorld")]
        [InlineData("Line1<br>Line2", "Line1\r\nLine2")]
        [InlineData("NoBrTag", "NoBrTag")]
        [InlineData("<br />Start", "\r\nStart")]
        [InlineData("End<br>", "End\r\n")]
        [InlineData("<br><br />", "\r\n\r\n")]
        [InlineData("Mix<br>ed<br />Tags", "Mix\r\ned\r\nTags")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void ConvertBrToNewLine_ReplacesBrTagsWithNewLine(string input, string expected)
        {
            var result = input?.ConvertBrToNewLine();
            Assert.Equal(expected, result);
        }
    }
}
