namespace Aymadoka.Static.StringExtension
{
    public class String_IsLikeTests
    {
        [Theory]
        [InlineData("hello", "hello", true)]
        [InlineData("hello", "h*o", true)]
        [InlineData("hello", "h?llo", true)]
        [InlineData("hello", "h?ll?", true)]
        [InlineData("hello", "h?ll", false)]
        [InlineData("h3llo", "h#llo", true)]
        [InlineData("hallo", "h[ae]llo", true)]
        [InlineData("hollo", "h[ae]llo", false)]
        [InlineData("hallo", "h[!o]llo", true)]
        [InlineData("hollo", "h[!o]llo", false)]
        [InlineData("file123.txt", "file*.txt", true)]
        [InlineData("file.txt", "file*.txt", true)]
        [InlineData("file.txt", "*.txt", true)]
        [InlineData("file.txt", "*.doc", false)]
        [InlineData("123", "###", true)]
        [InlineData("12a", "###", false)]
        [InlineData("", "", true)]
        [InlineData("", "*", true)]
        [InlineData("a", "?", true)]
        [InlineData("ab", "?", false)]
        public void IsLike_PatternMatching_WorksAsExpected(string input, string pattern, bool expected)
        {
            Assert.Equal(expected, input.IsLike(pattern));
        }
    }
}
