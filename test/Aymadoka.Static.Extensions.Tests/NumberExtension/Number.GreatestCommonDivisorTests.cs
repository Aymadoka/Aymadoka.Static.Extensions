namespace Aymadoka.Static.NumberExtension
{
    public class Number_GreatestCommonDivisorTests
    {
        [Theory]
        [InlineData(54, 24, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, 5)]
        [InlineData(5, 0, 5)]
        [InlineData(17, 13, 1)]
        [InlineData(-54, 24, -6)]
        [InlineData(54, -24, 6)]
        [InlineData(-54, -24, -6)]
        public void GreatestCommonDivisor_Int(int a, int b, int expected)
        {
            var act = a.GreatestCommonDivisor(b);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(54u, 24u, 6u)]
        [InlineData(0u, 0u, 0u)]
        [InlineData(0u, 5u, 5u)]
        [InlineData(5u, 0u, 5u)]
        [InlineData(17u, 13u, 1u)]
        public void GreatestCommonDivisor_UInt(uint a, uint b, uint expected)
        {
            Assert.Equal(expected, a.GreatestCommonDivisor(b));
        }

        [Theory]
        [InlineData(9223372036854775806L, 2L, 2L)]
        [InlineData(0L, 0L, 0L)]
        [InlineData(0L, 5L, 5L)]
        [InlineData(5L, 0L, 5L)]
        [InlineData(17L, 13L, 1L)]
        [InlineData(-9223372036854775806L, 2L, 2L)]
        [InlineData(9223372036854775806L, -2L, -2L)]
        [InlineData(-9223372036854775806L, -2L, -2L)]
        public void GreatestCommonDivisor_Long(long a, long b, long expected)
        {
            var act = a.GreatestCommonDivisor(b);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(9223372036854775806ul, 2ul, 2ul)]
        [InlineData(0ul, 0ul, 0ul)]
        [InlineData(0ul, 5ul, 5ul)]
        [InlineData(5ul, 0ul, 5ul)]
        [InlineData(17ul, 13ul, 1ul)]
        public void GreatestCommonDivisor_ULong(ulong a, ulong b, ulong expected)
        {
            Assert.Equal(expected, a.GreatestCommonDivisor(b));
        }
    }
}
