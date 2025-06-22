namespace Aymadoka.Static.StringExtension
{
    public class String_ReplaceWhenEqualsTests
    {
        [Theory]
        [InlineData("abc", "abc", "def", "def")]
        [InlineData("abc", "def", "xyz", "abc")]
        [InlineData("", "", "empty", "empty")]
        [InlineData(null, null, "null", "null")]
        [InlineData(null, "abc", "def", null)]
        [InlineData("abc", null, "def", "abc")]
        public void ReplaceWhenEquals_ReturnsExpectedResult(string input, string oldValue, string newValue, string expected)
        {
            var result = input.ReplaceWhenEquals(oldValue, newValue);
            Assert.Equal(expected, result);
        }
    }
}
