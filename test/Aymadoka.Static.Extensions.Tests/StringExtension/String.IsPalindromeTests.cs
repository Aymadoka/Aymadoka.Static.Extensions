namespace Aymadoka.Static.StringExtension
{
    public class String_IsPalindromeTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", false)] // 区分大小写
        [InlineData("madam", true)]
        [InlineData("racecar", true)]
        [InlineData("12321", true)]
        [InlineData("12345", false)]
        [InlineData("Was it a car or a cat I saw?", false)] // 区分大小写
        [InlineData("No lemon, no melon", false)] // 区分大小写
        [InlineData("Able was I ere I saw Elba", false)] // 区分大小写
        [InlineData("Madam", false)] // 区分大小写
        [InlineData("madAm", false)] // 区分大小写
        [InlineData("a", true)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData("!@#$", true)]
        public void IsPalindrome_VariousInputs_ReturnsExpected(string input, bool expected)
        {
            var result = input.IsPalindrome();
            Assert.Equal(expected, result);
        }
    }
}
