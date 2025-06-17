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

        [Theory]
        [InlineData("a_b_c_b_c", 2, "b", "x", "a_b_c_x_c")]
        [InlineData("a_b_b_b", 2, "b", "x", "a_b_x_x")]
        [InlineData("a_b_b_b", 3, "b", "x", "a_x_x_x")]
        [InlineData("a_b_b_b", 4, "b", "x", "a_x_x_x")]
        [InlineData("a_b_b_b", 0, "b", "x", "a_b_b_b")]
        [InlineData("abcabcabc", 2, "abc", "x", "abcx x")]
        [InlineData("abcabcabc", 1, "abc", "x", "abcabcx")]
        [InlineData("no match here", 2, "xyz", "123", "no match here")]
        [InlineData("", 2, "a", "b", "")]
        public void ReplaceLast_MultipleOccurrences_Works(string input, int number, string oldValue, string newValue, string expected)
        {
            var result = input.ReplaceLast(number, oldValue, newValue);
            Assert.Equal(expected, result);
        }
    }
}
