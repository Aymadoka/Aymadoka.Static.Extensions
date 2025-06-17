namespace Aymadoka.Static.StringExtension
{
    public class String_IsNotNullOrEmptyTests
    {
        [Theory]
        [InlineData("hello", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsNotNullOrEmpty_ReturnsExpectedResult(string? input, bool expected)
        {
            var result = input.IsNotNullOrEmpty();
            Assert.Equal(expected, result);
        }
    }
}
