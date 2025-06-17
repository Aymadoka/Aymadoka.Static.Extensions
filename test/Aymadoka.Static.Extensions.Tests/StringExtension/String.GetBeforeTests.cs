namespace Aymadoka.Static.StringExtension
{
    public class String_GetBeforeTests
    {
        [Theory]
        [InlineData("hello world", " ", "hello")]
        [InlineData("abcdefg", "cd", "ab")]
        [InlineData("abcdefg", "x", "")]
        [InlineData("abcdefg", "", "")]
        [InlineData("", "a", "")]
        [InlineData("testtest", "test", "")]
        [InlineData("foo_bar_baz", "_", "foo")]
        [InlineData("foo_bar_baz", "bar", "foo_")]
        public void GetBefore_ReturnsExpectedResult(string input, string value, string expected)
        {
            var result = input.GetBefore(value);
            Assert.Equal(expected, result);
        }
    }
}
