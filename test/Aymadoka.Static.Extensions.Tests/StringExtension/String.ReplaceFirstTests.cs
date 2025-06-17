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

        [Theory]
        [InlineData("a,b,c,b,a", 1, "b", "X", "a,b,cXb,a")]
        [InlineData("foo foo foo", 2, "foo", "bar", "foo foo bar")]
        [InlineData("abcabcabc", 0, "abc", "x", "xabcabc")]
        [InlineData("abcabcabc", 2, "abc", "x", "abcabcx")]
        [InlineData("abcabcabc", 3, "abc", "x", "abcabcabc")]
        [InlineData("no match", 0, "xyz", "123", "no match")]
        [InlineData("", 0, "a", "b", "")]
        public void ReplaceFirst_ReplacesNthOccurrence(string input, int number, string oldValue, string newValue, string expected)
        {
            var result = input.ReplaceFirst(number, oldValue, newValue);
            Assert.Equal(expected, result);
        }
    }
}
