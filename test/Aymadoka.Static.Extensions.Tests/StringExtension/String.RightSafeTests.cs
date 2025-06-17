namespace Aymadoka.Static.StringExtension
{
    public class String_RightSafeTests
    {
        [Theory]
        [InlineData("abcdef", 3, "def")]
        [InlineData("abcdef", 0, "")]
        [InlineData("abcdef", 6, "abcdef")]
        [InlineData("abcdef", 10, "abcdef")]
        [InlineData("", 3, "")]
        [InlineData(null, 3, null)]
        public void RightSafe_ReturnsExpectedResult(string input, int length, string expected)
        {
            if (input == null)
            {
                Assert.Throws<NullReferenceException>(() => input.RightSafe(length));
            }
            else
            {
                var result = input.RightSafe(length);
                Assert.Equal(expected, result);
            }
        }
    }
}
