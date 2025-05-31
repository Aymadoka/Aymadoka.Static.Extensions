namespace Aymadoka.Static.CharExtension
{
    public class Char_GetNumericValueTests
    {
        [Theory]
        [InlineData('0', 0)]
        [InlineData('5', 5)]
        [InlineData('9', 9)]
        [InlineData('Ⅷ', 8)] // 罗马数字
        [InlineData('⅓', 0.3333333333333333)] // 分数
        [InlineData('A', -1)]
        [InlineData(' ', -1)]
        public void GetNumericValue_ReturnsExpectedValue(char input, double expected)
        {
            double result = input.GetNumericValue();
            Assert.Equal(expected, result, 10);
        }
    }
}
