namespace Aymadoka.Static.StringExtension
{
    public class String_ExtractTests
    {
        [Fact]
        public void Extract_ShouldReturnOnlyDigits()
        {
            string input = "a1b2c3";
            string result = input.Extract(char.IsDigit);
            Assert.Equal("123", result);
        }

        [Fact]
        public void Extract_ShouldReturnOnlyLetters()
        {
            string input = "a1b2c3";
            string result = input.Extract(char.IsLetter);
            Assert.Equal("abc", result);
        }

        [Fact]
        public void Extract_ShouldReturnEmpty_WhenNoMatch()
        {
            string input = "12345";
            string result = input.Extract(char.IsLetter);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Extract_ShouldReturnOriginal_WhenAllMatch()
        {
            string input = "abcdef";
            string result = input.Extract(c => true);
            Assert.Equal("abcdef", result);
        }

        [Fact]
        public void Extract_ShouldReturnEmpty_WhenInputIsEmpty()
        {
            string input = "";
            string result = input.Extract(char.IsDigit);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Extract_ShouldThrowArgumentNullException_WhenInputIsNull()
        {
            string input = null;
            Assert.Throws<NullReferenceException>(() => input.Extract(char.IsDigit));
        }

        [Fact]
        public void Extract_ShouldThrowArgumentNullException_WhenPredicateIsNull()
        {
            string input = "abc";
            Assert.Throws<ArgumentNullException>(() => input.Extract(null));
        }
    }
}
