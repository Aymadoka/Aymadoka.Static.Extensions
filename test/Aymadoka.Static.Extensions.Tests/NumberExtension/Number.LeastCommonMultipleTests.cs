namespace Aymadoka.Static.NumberExtension
{
    public class Number_LeastCommonMultipleTests
    {
        [Theory]
        [InlineData(6, 8, 24)]
        [InlineData(15, 20, 60)]
        [InlineData(7, 3, 21)]
        [InlineData(0, 5, 0)]
        [InlineData(5, 0, 0)]
        public void LeastCommonMultiple_Int_TwoNumbers(int a, int b, int expected)
        {
            Assert.Equal(expected, a.LeastCommonMultiple(b));
        }

        [Fact]
        public void LeastCommonMultiple_Int_Array()
        {
            Assert.Equal(60, NumberExtensions.LeastCommonMultiple(4, 5, 6));
            Assert.Equal(12, NumberExtensions.LeastCommonMultiple(3, 4, 6));
            Assert.Equal(0, NumberExtensions.LeastCommonMultiple(0, 2, 3));
        }

        [Fact]
        public void LeastCommonMultiple_Int_Array_ThrowsOnEmpty()
        {
            Assert.Throws<ArgumentException>(() => NumberExtensions.LeastCommonMultiple(new int[0]));
        }

        [Theory]
        [InlineData(6u, 8u, 24u)]
        [InlineData(15u, 20u, 60u)]
        [InlineData(7u, 3u, 21u)]
        [InlineData(0u, 5u, 0u)]
        [InlineData(5u, 0u, 0u)]
        public void LeastCommonMultiple_UInt_TwoNumbers(uint a, uint b, uint expected)
        {
            Assert.Equal(expected, a.LeastCommonMultiple(b));
        }

        [Fact]
        public void LeastCommonMultiple_UInt_Array()
        {
            Assert.Equal(60u, NumberExtensions.LeastCommonMultiple(4u, 5u, 6u));
            Assert.Equal(12u, NumberExtensions.LeastCommonMultiple(3u, 4u, 6u));
            Assert.Equal(0u, NumberExtensions.LeastCommonMultiple(0u, 2u, 3u));
        }

        [Fact]
        public void LeastCommonMultiple_UInt_Array_ThrowsOnEmpty()
        {
            Assert.Throws<ArgumentException>(() => NumberExtensions.LeastCommonMultiple(new uint[0]));
        }

        [Theory]
        [InlineData(6L, 8L, 24L)]
        [InlineData(15L, 20L, 60L)]
        [InlineData(7L, 3L, 21L)]
        [InlineData(0L, 5L, 0L)]
        [InlineData(5L, 0L, 0L)]
        public void LeastCommonMultiple_Long_TwoNumbers(long a, long b, long expected)
        {
            Assert.Equal(expected, a.LeastCommonMultiple(b));
        }

        [Fact]
        public void LeastCommonMultiple_Long_Array()
        {
            Assert.Equal(60L, NumberExtensions.LeastCommonMultiple(4L, 5L, 6L));
            Assert.Equal(12L, NumberExtensions.LeastCommonMultiple(3L, 4L, 6L));
            Assert.Equal(0L, NumberExtensions.LeastCommonMultiple(0L, 2L, 3L));
        }

        [Fact]
        public void LeastCommonMultiple_Long_Array_ThrowsOnEmpty()
        {
            Assert.Throws<ArgumentException>(() => NumberExtensions.LeastCommonMultiple(new long[0]));
        }

        [Theory]
        [InlineData(6ul, 8ul, 24ul)]
        [InlineData(15ul, 20ul, 60ul)]
        [InlineData(7ul, 3ul, 21ul)]
        [InlineData(0ul, 5ul, 0ul)]
        [InlineData(5ul, 0ul, 0ul)]
        public void LeastCommonMultiple_ULong_TwoNumbers(ulong a, ulong b, ulong expected)
        {
            Assert.Equal(expected, a.LeastCommonMultiple(b));
        }

        [Fact]
        public void LeastCommonMultiple_ULong_Array()
        {
            Assert.Equal(60ul, NumberExtensions.LeastCommonMultiple(4ul, 5ul, 6ul));
            Assert.Equal(12ul, NumberExtensions.LeastCommonMultiple(3ul, 4ul, 6ul));
            Assert.Equal(0ul, NumberExtensions.LeastCommonMultiple(0ul, 2ul, 3ul));
        }

        [Fact]
        public void LeastCommonMultiple_ULong_Array_ThrowsOnEmpty()
        {
            Assert.Throws<ArgumentException>(() => NumberExtensions.LeastCommonMultiple(new ulong[0]));
        }
    }
}
