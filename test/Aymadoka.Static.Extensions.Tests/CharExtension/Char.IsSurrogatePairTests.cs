namespace Aymadoka.Static.CharExtension
{
    public class Char_IsSurrogatePairTests
    {
        [Theory]
        [InlineData('\uD800', '\uDC00', true)] // 有效代理项对
        [InlineData('\uDBFF', '\uDFFF', true)] // 有效代理项对
        [InlineData('\uD800', 'a', false)]     // 低代理项无效
        [InlineData('a', '\uDC00', false)]     // 高代理项无效
        [InlineData('a', 'b', false)]          // 都不是代理项
        [InlineData('\uDC00', '\uD800', false)]// 低代理项在前
        public void IsSurrogatePair_Test(char high, char low, bool expected)
        {
            var result = high.IsSurrogatePair(low);
            Assert.Equal(expected, result);
        }
    }
}
