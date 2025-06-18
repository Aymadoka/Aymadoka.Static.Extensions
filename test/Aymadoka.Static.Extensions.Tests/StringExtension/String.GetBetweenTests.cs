namespace Aymadoka.Static.StringExtension
{
    public class String_GetBetweenTests
    {
        [Theory]
        [InlineData("Hello [World]!", "[", "]", "World")]
        [InlineData("abc<def>ghi", "<", ">", "def")]
        [InlineData("no markers here", "[", "]", "")]
        [InlineData("start middle end", "start ", " end", "middle")]
        [InlineData("foo bar baz", "bar", "baz", " ")]
        [InlineData("foo bar baz", "baz", "bar", "")]
        [InlineData("foo bar baz", "foo", "baz", " bar ")]
        [InlineData("foo bar baz", "foo", "notfound", "")]
        [InlineData("foo bar baz", "notfound", "baz", "")]
        [InlineData("foo bar baz", "", "bar", "foo ")]
        [InlineData("", "a", "b", "")]
        public void GetBetween_ReturnsExpectedResult(string input, string before, string after, string expected)
        {
            var result = input.GetBetween(before, after);
            Assert.Equal(expected, result);
        }
    }
}
