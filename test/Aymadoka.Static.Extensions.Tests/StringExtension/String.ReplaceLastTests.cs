namespace Aymadoka.Static.StringExtension
{
    public class String_ReplaceLastTests
    {
        [Theory]
        [InlineData("foo_bar_bar", "bar", "baz", "foo_bar_baz")]
        [InlineData("hello world world", "world", "C#", "hello world C#")]
        [InlineData("abcabcabc", "abc", "x", "abcabcx")]
        [InlineData("no match here", "xyz", "123", "no match here")]
        [InlineData("", "a", "b", "")]
        public void ReplaceLast_OneOccurrence_Works(string input, string oldValue, string newValue, string expected)
        {
            var result = input.ReplaceLast(oldValue, newValue);
            Assert.Equal(expected, result);
        }
    }
}
