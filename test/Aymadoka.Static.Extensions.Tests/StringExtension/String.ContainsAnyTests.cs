namespace Aymadoka.Static.StringExtension
{
    public class String_ContainsAnyTests
    {
        [Theory]
        [InlineData("hello world", new[] { "world", "test" }, true)]
        [InlineData("hello world", new[] { "foo", "bar" }, false)]
        [InlineData("hello world", new[] { "hello" }, true)]
        [InlineData("hello world", new string[0], false)]
        [InlineData("", new[] { "" }, true)]
        [InlineData(null, new[] { "a" }, false)]
        public void ContainsAny_BasicTests(string source, string[] values, bool expected)
        {
            var result = source?.ContainsAny(values) ?? false;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("HELLO world", StringComparison.OrdinalIgnoreCase, new[] { "hello" }, true)]
        [InlineData("HELLO world", StringComparison.Ordinal, new[] { "hello" }, false)]
        [InlineData("test", StringComparison.Ordinal, new[] { "TEST", "t" }, true)]
        [InlineData("test", StringComparison.OrdinalIgnoreCase, new[] { "TEST" }, true)]
        [InlineData("test", StringComparison.Ordinal, new string[0], false)]
        [InlineData(null, StringComparison.Ordinal, new[] { "a" }, false)]
        public void ContainsAny_WithComparisonTests(string source, StringComparison comparison, string[] values, bool expected)
        {
            var result = source?.ContainsAny(comparison, values) ?? false;
            Assert.Equal(expected, result);
        }
    }
}
