using System.Globalization;

namespace Aymadoka.Static.StringExtension
{
    public class String_ToTitleCaseTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData("hello world", "Hello World")]
        [InlineData("HELLO WORLD", "HELLO WORLD")]
        [InlineData("hElLo wOrLd", "Hello World")]
        [InlineData("a test-case", "A Test-Case")]
        public void ToTitleCase_CurrentCulture_Works(string input, string expected)
        {
            var result = input.ToTitleCase();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToTitleCase_WithSpecificCulture_Works()
        {
            var input = "istanbul is a city";
            var turkishCulture = new CultureInfo("tr-TR");
            var result = input.ToTitleCase(turkishCulture);
            Assert.Equal("İstanbul İs A City", result);
        }

        [Fact]
        public void ToTitleCase_NullOrWhiteSpace_ReturnsInput()
        {
            Assert.Null(((string)null).ToTitleCase(CultureInfo.InvariantCulture));
            Assert.Equal("", "".ToTitleCase(CultureInfo.InvariantCulture));
            Assert.Equal("   ", "   ".ToTitleCase(CultureInfo.InvariantCulture));
        }
    }
}
