namespace Aymadoka.Static.StringExtension
{
    public class String_IsEmptyTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("abc", false)]
        [InlineData(null, false)]
        public void IsEmpty_ReturnsExpectedResult(string? input, bool expected)
        {
            var result = input.IsEmpty();
            Assert.Equal(expected, result);
        }
    }
}
