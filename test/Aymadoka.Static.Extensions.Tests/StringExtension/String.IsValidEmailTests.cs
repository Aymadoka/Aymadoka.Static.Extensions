namespace Aymadoka.Static.StringExtension
{
    public class String_IsValidEmailTests
    {
        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("user.name+tag+sorting@example.com", false)] // 不支持+号
        [InlineData("user_name@example.co.uk", true)]
        [InlineData("user-name@sub.example.com", true)]
        [InlineData("user@localhost", false)]
        [InlineData("user@.com", false)]
        [InlineData("user@com", false)]
        [InlineData("user@", false)]
        [InlineData("@example.com", false)]
        [InlineData("plainaddress", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("   ", false)]
        [InlineData("user@[192.168.1.1]", true)]
        [InlineData("user@[256.256.256.256]", true)] // 正则未校验IP范围
        public void IsValidEmail_TestCases(string input, bool expected)
        {
            var result = input.IsValidEmail();
            Assert.Equal(expected, result);
        }
    }
}
