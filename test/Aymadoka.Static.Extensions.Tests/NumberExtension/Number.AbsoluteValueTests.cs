namespace Aymadoka.Static.NumberExtension
{
    public class Number_AbsoluteValueTests
    {
        [Theory]
        [InlineData((sbyte)-128, (sbyte)128)]
        [InlineData((sbyte)-1, (sbyte)1)]
        [InlineData((sbyte)0, (sbyte)0)]
        [InlineData((sbyte)1, (sbyte)1)]
        public void AbsoluteValue_SByte_Works(sbyte input, sbyte expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData((byte)0, (short)0)]
        [InlineData((byte)1, (short)1)]
        [InlineData(byte.MaxValue, (short)255)]
        public void AbsoluteValue_Byte_Works(byte input, short expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData((short)-32768, (short)32768)]
        [InlineData((short)-1, (short)1)]
        [InlineData((short)0, (short)0)]
        [InlineData((short)1, (short)1)]
        public void AbsoluteValue_Short_Works(short input, short expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData((ushort)0, 0)]
        [InlineData((ushort)1, 1)]
        [InlineData(ushort.MaxValue, 65535)]
        public void AbsoluteValue_UShort_Works(ushort input, int expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData(-2147483648, 2147483648)]
        [InlineData(-1, 1)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        public void AbsoluteValue_Int_Works(int input, int expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData((uint)0, 0L)]
        [InlineData((uint)1, 1L)]
        [InlineData(uint.MaxValue, 4294967295L)]
        public void AbsoluteValue_UInt_Works(uint input, long expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData(-9223372036854775808L, 9223372036854775808L)]
        [InlineData(-1L, 1L)]
        [InlineData(0L, 0L)]
        [InlineData(1L, 1L)]
        public void AbsoluteValue_Long_Works(long input, long expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData(-1.5f, 1.5f)]
        [InlineData(0f, 0f)]
        [InlineData(1.5f, 1.5f)]
        public void AbsoluteValue_Float_Works(float input, float expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData(-1.5, 1.5)]
        [InlineData(0.0, 0.0)]
        [InlineData(1.5, 1.5)]
        public void AbsoluteValue_Double_Works(double input, double expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData(-1.5, 1.5)]
        [InlineData(0.0, 0.0)]
        [InlineData(1.5, 1.5)]
        public void AbsoluteValue_Decimal_Works(decimal input, decimal expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }
    }
}
