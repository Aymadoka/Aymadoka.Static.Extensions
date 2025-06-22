namespace Aymadoka.Static.StringExtension
{
    public class String_RepeatTests
    {
        [Fact]
        public void Repeat_WithNullString_ThrowsArgumentNullException()
        {
            string input = null;
            Assert.Throws<ArgumentNullException>(() => input.Repeat(1));
        }

        [Fact]
        public void Repeat_WithNegativeCount_ThrowsArgumentOutOfRangeException()
        {
            string input = "abc";
            Assert.Throws<ArgumentOutOfRangeException>(() => input.Repeat(-1));
        }

        [Fact]
        public void Repeat_WithZeroCount_ReturnsEmptyString()
        {
            string input = "abc";
            var result = input.Repeat(0);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Repeat_SingleCharacterString_ReturnsRepeatedCharacters()
        {
            string input = "a";
            var result = input.Repeat(5);
            Assert.Equal("aaaaa", result);
        }

        [Fact]
        public void Repeat_MultiCharacterString_ReturnsRepeatedString()
        {
            string input = "ab";
            var result = input.Repeat(3);
            Assert.Equal("ababab", result);
        }

        [Fact]
        public void Repeat_EmptyString_ReturnsEmptyString()
        {
            string input = "";
            var result = input.Repeat(10);
            Assert.Equal(string.Empty, result);
        }
    }
}
