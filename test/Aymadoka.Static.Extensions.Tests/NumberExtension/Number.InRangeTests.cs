namespace Aymadoka.Static.NumberExtension
{
    public class Number_InRangeTests
    {
        [Theory]
        [InlineData((sbyte)5, (sbyte)1, (sbyte)10, true)]
        [InlineData((sbyte)1, (sbyte)1, (sbyte)10, true)]
        [InlineData((sbyte)10, (sbyte)1, (sbyte)10, true)]
        [InlineData((sbyte)0, (sbyte)1, (sbyte)10, false)]
        [InlineData((sbyte)11, (sbyte)1, (sbyte)10, false)]
        public void InRange_SByte_Works(sbyte value, sbyte min, sbyte max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData((byte)5, (byte)1, (byte)10, true)]
        [InlineData((byte)1, (byte)1, (byte)10, true)]
        [InlineData((byte)10, (byte)1, (byte)10, true)]
        [InlineData((byte)0, (byte)1, (byte)10, false)]
        [InlineData((byte)11, (byte)1, (byte)10, false)]
        public void InRange_Byte_Works(byte value, byte min, byte max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData((short)5, (short)1, (short)10, true)]
        [InlineData((short)1, (short)1, (short)10, true)]
        [InlineData((short)10, (short)1, (short)10, true)]
        [InlineData((short)0, (short)1, (short)10, false)]
        [InlineData((short)11, (short)1, (short)10, false)]
        public void InRange_Short_Works(short value, short min, short max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData((ushort)5, (ushort)1, (ushort)10, true)]
        [InlineData((ushort)1, (ushort)1, (ushort)10, true)]
        [InlineData((ushort)10, (ushort)1, (ushort)10, true)]
        [InlineData((ushort)0, (ushort)1, (ushort)10, false)]
        [InlineData((ushort)11, (ushort)1, (ushort)10, false)]
        public void InRange_UShort_Works(ushort value, ushort min, ushort max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData(5, 1, 10, true)]
        [InlineData(1, 1, 10, true)]
        [InlineData(10, 1, 10, true)]
        [InlineData(0, 1, 10, false)]
        [InlineData(11, 1, 10, false)]
        public void InRange_Int_Works(int value, int min, int max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData(5u, 1u, 10u, true)]
        [InlineData(1u, 1u, 10u, true)]
        [InlineData(10u, 1u, 10u, true)]
        [InlineData(0u, 1u, 10u, false)]
        [InlineData(11u, 1u, 10u, false)]
        public void InRange_UInt_Works(uint value, uint min, uint max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData(5L, 1L, 10L, true)]
        [InlineData(1L, 1L, 10L, true)]
        [InlineData(10L, 1L, 10L, true)]
        [InlineData(0L, 1L, 10L, false)]
        [InlineData(11L, 1L, 10L, false)]
        public void InRange_Long_Works(long value, long min, long max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData(5ul, 1ul, 10ul, true)]
        [InlineData(1ul, 1ul, 10ul, true)]
        [InlineData(10ul, 1ul, 10ul, true)]
        [InlineData(0ul, 1ul, 10ul, false)]
        [InlineData(11ul, 1ul, 10ul, false)]
        public void InRange_ULong_Works(ulong value, ulong min, ulong max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData(5.0f, 1.0f, 10.0f, true)]
        [InlineData(1.0f, 1.0f, 10.0f, true)]
        [InlineData(10.0f, 1.0f, 10.0f, true)]
        [InlineData(0.0f, 1.0f, 10.0f, false)]
        [InlineData(11.0f, 1.0f, 10.0f, false)]
        [InlineData(float.NaN, 1.0f, 10.0f, false)]
        public void InRange_Float_Works(float value, float min, float max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData(5.0, 1.0, 10.0, true)]
        [InlineData(1.0, 1.0, 10.0, true)]
        [InlineData(10.0, 1.0, 10.0, true)]
        [InlineData(0.0, 1.0, 10.0, false)]
        [InlineData(11.0, 1.0, 10.0, false)]
        [InlineData(double.NaN, 1.0, 10.0, false)]
        public void InRange_Double_Works(double value, double min, double max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }

        [Theory]
        [InlineData(5.0, 1.0, 10.0, true)]
        [InlineData(1.0, 1.0, 10.0, true)]
        [InlineData(10.0, 1.0, 10.0, true)]
        [InlineData(0.0, 1.0, 10.0, false)]
        [InlineData(11.0, 1.0, 10.0, false)]
        public void InRange_Decimal_Works(decimal value, decimal min, decimal max, bool expected)
        {
            Assert.Equal(expected, value.InRange(min, max));
        }
    }
}
