namespace Aymadoka.Static.StringExtension
{
    public class String_IsValidPhoneNumberTests
    {
        [Theory]
        [InlineData("+86 13800138000", true)]
        [InlineData("13800138000", true)]
        [InlineData("010-88886666", true)]
        [InlineData("400-800-1234", true)]
        [InlineData("1234567", true)]
        [InlineData("123-4567-8901", true)]
        [InlineData("1234 567 890", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("   ", false)]
        [InlineData("abcdefg", false)]
        [InlineData("123-abc-4567", false)]
        [InlineData("!@#$%^&*", false)]
        public void IsValidPhoneNumber_TestCases(string? input, bool expected)
        {
            var result = input.IsValidPhoneNumber();
            Assert.Equal(expected, result);
        }
    }
}
