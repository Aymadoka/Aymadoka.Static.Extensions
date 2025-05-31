namespace Aymadoka.Static.CharExtension
{
    public class Char_IsSeparatorTests
    {
        [Theory]
        [InlineData(' ', true)]
        [InlineData('\u2028', true)] // 行分隔符
        [InlineData('\u2029', true)] // 段分隔符
        [InlineData('a', false)]
        [InlineData('1', false)]
        [InlineData(',', false)]
        public void IsSeparator_ReturnsExpected(char input, bool expected)
        {
            bool result = input.IsSeparator();
            Assert.Equal(expected, result);
        }
    }
}
