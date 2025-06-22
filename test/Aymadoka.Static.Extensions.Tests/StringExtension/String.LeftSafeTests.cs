namespace Aymadoka.Static.StringExtension
{
    public class String_LeftSafeTests
    {
        [Theory]
        [InlineData("abcdef", 3, "abc")]
        [InlineData("abcdef", 0, "")]
        [InlineData("abcdef", 6, "abcdef")]
        [InlineData("abcdef", 10, "abcdef")]
        [InlineData("", 5, "")]
        public void LeftSafe_ReturnsExpectedResult(string input, int length, string expected)
        {
            var result = input.LeftSafe(length);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeftSafe_NullString_ThrowsArgumentNullException()
        {
            string input = null;
            Assert.Throws<NullReferenceException>(() => input.LeftSafe(3));
        }

        [Fact]
        public void LeftSafe_NegativeLength_ThrowsArgumentOutOfRangeException()
        {
            string input = "abcdef";
            Assert.Throws<ArgumentOutOfRangeException>(() => input.LeftSafe(-1));
        }
    }
}
