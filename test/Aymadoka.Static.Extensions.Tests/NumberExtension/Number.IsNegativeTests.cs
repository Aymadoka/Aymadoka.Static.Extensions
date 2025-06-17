using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsNegativeTests
    {
        [Theory]
        [InlineData((sbyte)-1, true)]
        [InlineData((sbyte)0, false)]
        [InlineData((sbyte)1, false)]
        public void IsNegative_SByte_Works(sbyte value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((byte)0, false)]
        [InlineData((byte)1, false)]
        [InlineData(byte.MaxValue, false)]
        public void IsNegative_Byte_Works(byte value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((short)-1, true)]
        [InlineData((short)0, false)]
        [InlineData((short)1, false)]
        public void IsNegative_Short_Works(short value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((ushort)0, false)]
        [InlineData((ushort)1, false)]
        [InlineData(ushort.MaxValue, false)]
        public void IsNegative_UShort_Works(ushort value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1, true)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        public void IsNegative_Int_Works(int value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((uint)0, false)]
        [InlineData((uint)1, false)]
        [InlineData(uint.MaxValue, false)]
        public void IsNegative_UInt_Works(uint value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1L, true)]
        [InlineData(0L, false)]
        [InlineData(1L, false)]
        public void IsNegative_Long_Works(long value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((ulong)0, false)]
        [InlineData((ulong)1, false)]
        [InlineData(ulong.MaxValue, false)]
        public void IsNegative_ULong_Works(ulong value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1.0f, true)]
        [InlineData(0.0f, false)]
        [InlineData(1.0f, false)]
        [InlineData(float.NegativeInfinity, true)]
        [InlineData(float.PositiveInfinity, false)]
        [InlineData(float.NaN, false)]
        public void IsNegative_Float_Works(float value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1.0, true)]
        [InlineData(0.0, false)]
        [InlineData(1.0, false)]
        [InlineData(double.NegativeInfinity, true)]
        [InlineData(double.PositiveInfinity, false)]
        [InlineData(double.NaN, false)]
        public void IsNegative_Double_Works(double value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalIsNegativeData()
        {
            yield return new object[] { -1.0m, true };
            yield return new object[] { 0.0m, false };
            yield return new object[] { 1.0m, false };
        }

        [Theory]
        [MemberData(nameof(DecimalIsNegativeData))]
        public void IsNegative_Decimal_Works(decimal value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }
    }
}
