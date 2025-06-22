namespace Aymadoka.Static.StringExtension
{
    public class String_IsValidIPv4Tests
    {
        [Theory]
        [InlineData("192.168.1.1", true)]
        [InlineData("0.0.0.0", true)]
        [InlineData("255.255.255.255", true)]
        [InlineData("127.0.0.1", true)]
        [InlineData("256.0.0.1", false)]
        [InlineData("192.168.1", false)]
        [InlineData("192.168.1.1.1", false)]
        [InlineData("192.168.1.a", false)]
        [InlineData("192.168.01.1", false)]
        [InlineData("192.168.1.01", false)]
        [InlineData("192.168.1.256", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        public void IsValidIPv4_TestCases(string input, bool expected)
        {
            var result = input.IsValidIPv4();
            Assert.Equal(expected, result);
        }
    }
}
