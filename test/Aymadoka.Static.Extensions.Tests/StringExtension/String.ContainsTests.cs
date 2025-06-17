namespace Aymadoka.Static.StringExtension
{
    public class String_ContainsTests
    {
        [Theory]
        [InlineData("hello world", "world", true)]
        [InlineData("hello world", "WORLD", false)]
        [InlineData("hello world", "", true)]
        [InlineData("", "a", false)]
        [InlineData("", "", true)]
        [InlineData("abc", "d", false)]
        public void Contains_DefaultComparison_Works(string source, string value, bool expected)
        {
            var result = source.Contains(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("hello world", "WORLD", true)]
        [InlineData("hello world", "world", true)]
        [InlineData("hello world", "test", false)]
        [InlineData("hello world", "", true)]
        [InlineData("", "a", false)]
        [InlineData("", "", true)]
        public void Contains_WithComparison_Works(string source, string value, bool expected)
        {
            var result = source.Contains(value, StringComparison.OrdinalIgnoreCase);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Contains_NullSource_Throws()
        {
            string source = null;
            Assert.Throws<ArgumentNullException>(() => source.Contains("a"));
            Assert.Throws<ArgumentNullException>(() => source.Contains("a", StringComparison.Ordinal));
        }

        [Fact]
        public void Contains_NullValue_Throws()
        {
            string source = "abc";
            string value = null;
            Assert.Throws<ArgumentNullException>(() => source.Contains(value));
            Assert.Throws<ArgumentNullException>(() => source.Contains(value, StringComparison.Ordinal));
        }
    }
}
