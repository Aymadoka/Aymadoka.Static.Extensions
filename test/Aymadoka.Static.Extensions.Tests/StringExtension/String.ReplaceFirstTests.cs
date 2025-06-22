namespace Aymadoka.Static.StringExtension
{
    public class String_ReplaceFirstTests
    {
        [Theory]
        [InlineData("hello world", "world", "C#", "hello C#")]
        [InlineData("foo bar foo", "foo", "baz", "baz bar foo")]
        [InlineData("abcabcabc", "abc", "x", "xabcabc")]
        [InlineData("no match", "xyz", "123", "no match")]
        [InlineData("", "a", "b", "")]
        public void ReplaceFirst_ReplacesFirstOccurrence(string input, string oldValue, string newValue, string expected)
        {
            var result = input.ReplaceFirst(oldValue, newValue);
            Assert.Equal(expected, result);
        }
    }
}
