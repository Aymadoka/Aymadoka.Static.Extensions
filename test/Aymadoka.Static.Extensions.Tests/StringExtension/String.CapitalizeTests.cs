namespace Aymadoka.Static.StringExtension
{
    public class String_CapitalizeTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("a", "A")]
        [InlineData("abc", "Abc")]
        [InlineData("Abc", "Abc")]
        [InlineData("1abc", "1abc")]
        [InlineData(" hello", " hello")]
        public void Capitalize_ReturnsExpectedResult(string input, string expected)
        {
            var result = input.Capitalize();
            Assert.Equal(expected, result);
        }
    }
}
