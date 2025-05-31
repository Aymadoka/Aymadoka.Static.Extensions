namespace Aymadoka.Static.CharExtension
{
    public class Char_IsHighSurrogateTests
    {
        [Theory]
        [InlineData('\uD800', true)] // 最低高代理项
        [InlineData('\uDBFF', true)] // 最高高代理项
        [InlineData('\uDC00', false)] // 低代理项
        [InlineData('A', false)] // 普通字符
        [InlineData('\uFFFF', false)] // 非代理项
        public void IsHighSurrogate_ReturnsExpected(char input, bool expected)
        {
            bool result = input.IsHighSurrogate();
            Assert.Equal(expected, result);
        }
    }
}
