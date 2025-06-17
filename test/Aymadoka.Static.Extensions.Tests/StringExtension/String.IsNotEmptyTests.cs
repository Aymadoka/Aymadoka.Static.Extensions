namespace Aymadoka.Static.StringExtension
{
    public class String_IsNotEmptyTests
    {
        public class StringExtensionsTests
        {
            [Theory]
            [InlineData("abc", true)]
            [InlineData(" ", true)]
            [InlineData("0", true)]
            [InlineData("", false)]
            [InlineData(null, true)]
            public void IsNotEmpty_ReturnsExpectedResult(string? input, bool expected)
            {
                var result = input.IsNotEmpty();
                Assert.Equal(expected, result);
            }
        }
    }
}
