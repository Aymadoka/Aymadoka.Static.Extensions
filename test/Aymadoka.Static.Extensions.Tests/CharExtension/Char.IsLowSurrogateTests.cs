namespace Aymadoka.Static.CharExtension
{
    public class Char_IsLowSurrogateTests
    {
        [Theory]
        [InlineData('\uDC00', true)] // 最小低代理项
        [InlineData('\uDFFF', true)] // 最大低代理项
        [InlineData('\uD800', false)] // 高代理项
        [InlineData('\uDBFF', false)] // 高代理项
        [InlineData('A', false)] // 普通字符
        [InlineData('\u0000', false)] // 最小Unicode
        [InlineData('\uFFFF', false)] // 最大Unicode
        public void IsLowSurrogate_ReturnsExpected(char input, bool expected)
        {
            bool result = input.IsLowSurrogate();
            Assert.Equal(expected, result);
        }
    }
}
