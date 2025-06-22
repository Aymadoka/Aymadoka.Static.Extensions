namespace Aymadoka.Static.StringExtension
{
    public class String_ConvertNewLineToBrTests
    {
        [Theory]
        [InlineData("Hello\r\nWorld", "Hello<br />World")]
        [InlineData("Hello\nWorld", "Hello<br />World")]
        [InlineData("Hello\r\nWorld\nTest", "Hello<br />World<br />Test")]
        [InlineData("NoNewLine", "NoNewLine")]
        [InlineData("", "")]
        [InlineData("\r\n", "<br />")]
        [InlineData("\n", "<br />")]
        [InlineData("Line1\r\nLine2\nLine3", "Line1<br />Line2<br />Line3")]
        public void Nl2Br_ReplacesNewLinesWithBr(string input, string expected)
        {
            var result = input.Nl2Br();
            Assert.Equal(expected, result);
        }
    }
}
