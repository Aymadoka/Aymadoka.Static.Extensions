namespace Aymadoka.Static.NumberExtension
{
    public class Number_BetweenTests
    {
        [Theory]
        [InlineData((sbyte)5, (sbyte)1, (sbyte)10, true)]
        [InlineData((sbyte)1, (sbyte)1, (sbyte)10, false)]
        [InlineData((sbyte)10, (sbyte)1, (sbyte)10, false)]
        [InlineData((sbyte)0, (sbyte)-5, (sbyte)0, false)]
        public void SByte_Between_Test(sbyte value, sbyte min, sbyte max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData((byte)5, (byte)1, (byte)10, true)]
        [InlineData((byte)1, (byte)1, (byte)10, false)]
        [InlineData((byte)10, (byte)1, (byte)10, false)]
        public void Byte_Between_Test(byte value, byte min, byte max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData((short)5, (short)1, (short)10, true)]
        [InlineData((short)1, (short)1, (short)10, false)]
        [InlineData((short)10, (short)1, (short)10, false)]
        public void Short_Between_Test(short value, short min, short max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData((ushort)5, (ushort)1, (ushort)10, true)]
        [InlineData((ushort)1, (ushort)1, (ushort)10, false)]
        [InlineData((ushort)10, (ushort)1, (ushort)10, false)]
        public void UShort_Between_Test(ushort value, ushort min, ushort max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData(5, 1, 10, true)]
        [InlineData(1, 1, 10, false)]
        [InlineData(10, 1, 10, false)]
        public void Int_Between_Test(int value, int min, int max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData(5u, 1u, 10u, true)]
        [InlineData(1u, 1u, 10u, false)]
        [InlineData(10u, 1u, 10u, false)]
        public void UInt_Between_Test(uint value, uint min, uint max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData(5L, 1L, 10L, true)]
        [InlineData(1L, 1L, 10L, false)]
        [InlineData(10L, 1L, 10L, false)]
        public void Long_Between_Test(long value, long min, long max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData(5ul, 1ul, 10ul, true)]
        [InlineData(1ul, 1ul, 10ul, false)]
        [InlineData(10ul, 1ul, 10ul, false)]
        public void ULong_Between_Test(ulong value, ulong min, ulong max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData(5.5f, 1.1f, 10.2f, true)]
        [InlineData(1.1f, 1.1f, 10.2f, false)]
        [InlineData(10.2f, 1.1f, 10.2f, false)]
        [InlineData(0f, -1f, 1f, true)]
        public void Float_Between_Test(float value, float min, float max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData(5.5, 1.1, 10.2, true)]
        [InlineData(1.1, 1.1, 10.2, false)]
        [InlineData(10.2, 1.1, 10.2, false)]
        [InlineData(0.0, -1.0, 1.0, true)]
        public void Double_Between_Test(double value, double min, double max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }

        [Theory]
        [InlineData(5.5, 1.1, 10.2, true)]
        [InlineData(1.1, 1.1, 10.2, false)]
        [InlineData(10.2, 1.1, 10.2, false)]
        [InlineData(0.0, -1.0, 1.0, true)]
        public void Decimal_Between_Test(decimal value, decimal min, decimal max, bool expected)
        {
            Assert.Equal(expected, value.Between(min, max));
        }
    }
}
