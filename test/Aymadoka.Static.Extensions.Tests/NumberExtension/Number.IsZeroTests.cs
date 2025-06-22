using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsZeroTests
    {
        [Theory]
        [InlineData((sbyte)0, true)]
        [InlineData((sbyte)1, false)]
        [InlineData((sbyte)-1, false)]
        public void IsZero_SByte_Works(sbyte value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((byte)0, true)]
        [InlineData((byte)1, false)]
        [InlineData((byte)255, false)]
        public void IsZero_Byte_Works(byte value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((short)0, true)]
        [InlineData((short)1, false)]
        [InlineData((short)-1, false)]
        public void IsZero_Short_Works(short value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((ushort)0, true)]
        [InlineData((ushort)1, false)]
        [InlineData((ushort)65535, false)]
        public void IsZero_UShort_Works(ushort value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(-1, false)]
        public void IsZero_Int_Works(int value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0u, true)]
        [InlineData(1u, false)]
        [InlineData(uint.MaxValue, false)]
        public void IsZero_UInt_Works(uint value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0L, true)]
        [InlineData(1L, false)]
        [InlineData(-1L, false)]
        public void IsZero_Long_Works(long value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0UL, true)]
        [InlineData(1UL, false)]
        [InlineData(ulong.MaxValue, false)]
        public void IsZero_ULong_Works(ulong value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0f, true)]
        [InlineData(1e-7f, true)]
        [InlineData(-1e-7f, true)]
        [InlineData(1e-5f, false)]
        [InlineData(-1e-5f, false)]
        [InlineData(1f, false)]
        public void IsZero_Float_Works(float value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0d, true)]
        [InlineData(1e-10d, true)]
        [InlineData(-1e-10d, true)]
        [InlineData(1e-8d, false)]
        [InlineData(-1e-8d, false)]
        [InlineData(1d, false)]
        public void IsZero_Double_Works(double value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalIsZeroData()
        {
            yield return new object[] { 0m, true };
            yield return new object[] { 1m, false };
            yield return new object[] { -1m, false };
            yield return new object[] { 0.00000000000000000000000001m, false };
        }

        [Theory]
        [MemberData(nameof(DecimalIsZeroData))]
        public void IsZero_Decimal_Works(decimal value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }
    }
}
