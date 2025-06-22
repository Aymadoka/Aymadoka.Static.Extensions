namespace Aymadoka.Static.StringExtension
{
    public class String_ReplaceByEmptyTests
    {
        [Theory]
        [InlineData("hello world", new string[] { "hello" }, " world")]
        [InlineData("abc123abc", new string[] { "abc", "1" }, "23")]
        [InlineData("test", new string[] { "notfound" }, "test")]
        [InlineData("aabbcc", new string[] { "a", "b", "c" }, "")]
        [InlineData("", new string[] { "a" }, "")]
        [InlineData("foo", new string[0], "foo")]
        public void ReplaceByEmpty_RemovesAllSpecifiedSubstrings(string input, string[] values, string expected)
        {
            var result = input.ReplaceByEmpty(values);
            Assert.Equal(expected, result);
        }
    }
}
