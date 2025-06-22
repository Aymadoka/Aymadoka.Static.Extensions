using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public class String_MatchTests
    {
        [Fact]
        public void Match_ReturnsFirstMatch_WhenPatternExists()
        {
            string input = "abc123def456";
            string pattern = @"\d+";

            var match = input.Match(pattern);

            Assert.True(match.Success);
            Assert.Equal("123", match.Value);
        }

        [Fact]
        public void Match_ReturnsEmptyMatch_WhenPatternNotFound()
        {
            string input = "abcdef";
            string pattern = @"\d+";

            var match = input.Match(pattern);

            Assert.False(match.Success);
            Assert.Equal(string.Empty, match.Value);
        }

        [Fact]
        public void Match_WithOptions_RespectsRegexOptions()
        {
            string input = "ABCdef";
            string pattern = @"abc";

            var match = input.Match(pattern, RegexOptions.IgnoreCase);

            Assert.True(match.Success);
            Assert.Equal("ABC", match.Value);
        }

        [Fact]
        public void Match_WithOptions_CaseSensitive()
        {
            string input = "ABCdef";
            string pattern = @"abc";

            var match = input.Match(pattern, RegexOptions.None);

            Assert.False(match.Success);
        }
    }
}
