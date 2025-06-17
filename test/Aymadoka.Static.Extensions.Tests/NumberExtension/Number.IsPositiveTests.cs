using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsPositiveTests
    {
        [Theory]
        [InlineData((sbyte)1, true)]
        [InlineData((sbyte)0, false)]
        [InlineData((sbyte)-1, false)]
        public void IsPositive_SByte_Test(sbyte value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((byte)1, true)]
        [InlineData((byte)0, false)]
        public void IsPositive_Byte_Test(byte value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((short)1, true)]
        [InlineData((short)0, false)]
        [InlineData((short)-1, false)]
        public void IsPositive_Short_Test(short value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((ushort)1, true)]
        [InlineData((ushort)0, false)]
        public void IsPositive_UShort_Test(ushort value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(-1, false)]
        public void IsPositive_Int_Test(int value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((uint)1, true)]
        [InlineData((uint)0, false)]
        public void IsPositive_UInt_Test(uint value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1L, true)]
        [InlineData(0L, false)]
        [InlineData(-1L, false)]
        public void IsPositive_Long_Test(long value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((ulong)1, true)]
        [InlineData((ulong)0, false)]
        public void IsPositive_ULong_Test(ulong value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1.0f, true)]
        [InlineData(0.0f, false)]
        [InlineData(-1.0f, false)]
        [InlineData(float.NaN, false)]
        public void IsPositive_Float_Test(float value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1.0, true)]
        [InlineData(0.0, false)]
        [InlineData(-1.0, false)]
        [InlineData(double.NaN, false)]
        public void IsPositive_Double_Test(double value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalIsPositiveData()
        {
            yield return new object[] { 1.0m, true };
            yield return new object[] { 0.0m, false };
            yield return new object[] { -1.0m, false };
        }

        [Theory]
        [MemberData(nameof(DecimalIsPositiveData))]
        public void IsPositive_Decimal_Test(decimal value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }
    }
}
