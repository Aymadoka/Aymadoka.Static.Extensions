namespace Aymadoka.Static.StringExtension
{
    public class String_IsValidUrlTests
    {
        [Theory]
        [InlineData("https://www.example.com", true)]
        [InlineData("http://localhost:8080", true)]
        [InlineData("ftp://ftp.example.com", true)]
        [InlineData("not a url", false)]
        [InlineData("www.example.com", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("http:/invalid.com", false)]
        [InlineData("https://", false)]
        public void IsValidUrl_ReturnsExpectedResult(string input, bool expected)
        {
            var result = StringExtensions.IsValidUrl(input);
            Assert.Equal(expected, result);
        }
    }
}
