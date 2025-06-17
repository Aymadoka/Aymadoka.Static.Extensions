namespace Aymadoka.Static.StringExtension
{
    public class String_ExtractNumberTests
    {
        [Theory]
        [InlineData("abc123def456", "123456")]
        [InlineData("no numbers", "")]
        [InlineData("2024-06-01", "20240601")]
        [InlineData("0a1b2c3", "0123")]
        [InlineData("", "")]
        [InlineData("１２３abc４５６", "１２３４５６")] // 包含全角数字
        public void ExtractNumber_ReturnsOnlyNumbers(string input, string expected)
        {
            var result = input.ExtractNumber();
            Assert.Equal(expected, result);
        }
    }
}
