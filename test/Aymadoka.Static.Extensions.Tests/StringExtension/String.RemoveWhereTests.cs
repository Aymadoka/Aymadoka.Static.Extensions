namespace Aymadoka.Static.StringExtension
{
    public class String_RemoveWhereTests
    {
        [Fact]
        public void RemoveWhere_RemovesSpecifiedCharacters()
        {
            string input = "a1b2c3d4";
            string result = input.RemoveWhere(char.IsDigit);
            Assert.Equal("abcd", result);
        }

        [Fact]
        public void RemoveWhere_NoCharactersRemoved_WhenPredicateIsFalse()
        {
            string input = "hello";
            string result = input.RemoveWhere(c => false);
            Assert.Equal("hello", result);
        }

        [Fact]
        public void RemoveWhere_AllCharactersRemoved_WhenPredicateIsTrue()
        {
            string input = "test";
            string result = input.RemoveWhere(c => true);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveWhere_RemovesWhitespace()
        {
            string input = "a b c d";
            string result = input.RemoveWhere(char.IsWhiteSpace);
            Assert.Equal("abcd", result);
        }

        [Fact]
        public void RemoveWhere_EmptyString_ReturnsEmpty()
        {
            string input = "";
            string result = input.RemoveWhere(char.IsLetter);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveWhere_NullPredicate_ThrowsArgumentNullException()
        {
            string input = "abc";
            var result = input.RemoveWhere(null);

            Assert.Equal(result, input);
        }

        [Fact]
        public void RemoveWhere_ThrowsArgumentNullException_WhenSourceIsNull()
        {
            // Arrange
            string source = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => source.RemoveWhere(c => c == 'a'));
        }
    }
}
