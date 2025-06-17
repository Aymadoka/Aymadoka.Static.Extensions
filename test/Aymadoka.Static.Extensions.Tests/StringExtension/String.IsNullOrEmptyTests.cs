namespace Aymadoka.Static.StringExtension
{
    public class String_IsNullOrEmptyTests
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("test", false)]
        public void IsNullOrEmpty_ReturnsExpectedResult(string? input, bool expected)
        {
            // Act
            var result = input.IsNullOrEmpty();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
