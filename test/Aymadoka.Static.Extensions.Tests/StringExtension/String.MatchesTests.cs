using System.Text.RegularExpressions;

namespace Aymadoka.Static.StringExtension
{
    public class String_MatchesTests
    {
        [Fact]
        public void Matches_WithValidPattern_ReturnsAllMatches()
        {
            // Arrange
            string input = "abc 123 def 456";
            string pattern = @"\d+";

            // Act
            var matches = input.Matches(pattern);

            // Assert
            Assert.Equal(2, matches.Count);
            Assert.Equal("123", matches[0].Value);
            Assert.Equal("456", matches[1].Value);
        }

        [Fact]
        public void Matches_WithRegexOptionsIgnoreCase_ReturnsMatches()
        {
            // Arrange
            string input = "Abc aBc ABC";
            string pattern = @"abc";

            // Act
            var matches = input.Matches(pattern, RegexOptions.IgnoreCase);

            // Assert
            Assert.Equal(3, matches.Count);
            Assert.All(matches, m => Assert.Equal("Abc", m.Value, ignoreCase: true));
        }

        [Fact]
        public void Matches_WithNoMatch_ReturnsEmptyCollection()
        {
            // Arrange
            string input = "no digits here";
            string pattern = @"\d+";

            // Act
            var matches = input.Matches(pattern);

            // Assert
            Assert.Empty(matches);
        }

        [Fact]
        public void Matches_WithNullInput_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;
            string pattern = @"\d+";

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => input.Matches(pattern));
        }

        [Fact]
        public void Matches_WithNullPattern_ThrowsArgumentNullException()
        {
            // Arrange
            string input = "abc";
            string pattern = null;

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => input.Matches(pattern));
        }
    }
}
