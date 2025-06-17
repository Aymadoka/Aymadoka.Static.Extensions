namespace Aymadoka.Static.StringExtension
{
    public class String_IsAnagramTests
    {
        [Theory]
        [InlineData("listen", "silent", true)]
        [InlineData("triangle", "integral", true)]
        [InlineData("apple", "papel", true)]
        [InlineData("rat", "car", false)]
        [InlineData("hello", "bello", false)]
        [InlineData("", "", true)]
        [InlineData("a", "a", true)]
        [InlineData("a", "b", false)]
        [InlineData("abc", "ab", false)]
        [InlineData("abc", "abcd", false)]
        public void IsAnagram_ReturnsExpectedResult(string str1, string str2, bool expected)
        {
            var result = str1.IsAnagram(str2);
            Assert.Equal(expected, result);
        }
    }
}
