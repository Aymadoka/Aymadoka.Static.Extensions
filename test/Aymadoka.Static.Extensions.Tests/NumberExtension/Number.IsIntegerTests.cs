using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsIntegerTests
    {
        [Theory]
        [InlineData((sbyte)0, true)]
        [InlineData((sbyte)1, true)]
        [InlineData((sbyte)-1, true)]
        public void IsInteger_SByte_Test(sbyte value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((byte)0, true)]
        [InlineData((byte)1, true)]
        [InlineData((byte)255, true)]
        public void IsInteger_Byte_Test(byte value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((short)0, true)]
        [InlineData((short)1, true)]
        [InlineData((short)-32768, true)]
        public void IsInteger_Short_Test(short value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((ushort)0, true)]
        [InlineData((ushort)1, true)]
        [InlineData((ushort)65535, true)]
        public void IsInteger_UShort_Test(ushort value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(-1, true)]
        public void IsInteger_Int_Test(int value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((uint)0, true)]
        [InlineData((uint)1, true)]
        [InlineData(uint.MaxValue, true)]
        public void IsInteger_UInt_Test(uint value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0L, true)]
        [InlineData(1L, true)]
        [InlineData(-1L, true)]
        public void IsInteger_Long_Test(long value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((ulong)0, true)]
        [InlineData((ulong)1, true)]
        [InlineData(ulong.MaxValue, true)]
        public void IsInteger_ULong_Test(ulong value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0f, true)]
        [InlineData(1f, true)]
        [InlineData(-1f, true)]
        [InlineData(1.000001f, true)]
        [InlineData(1.0000001f, true)] // within epsilon
        [InlineData(1.5f, false)]
        public void IsInteger_Float_Test(float value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0d, true)]
        [InlineData(1d, true)]
        [InlineData(-1d, true)]
        [InlineData(1.0000000001d, true)]
        [InlineData(1.00000000001d, true)] // within epsilon
        [InlineData(1.5d, false)]
        public void IsInteger_Double_Test(double value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalIsIntegerData()
        {
            yield return new object[] { 0m, true };
            yield return new object[] { 1m, true };
            yield return new object[] { -1m, true };
            yield return new object[] { 1.5m, false };
        }

        [Theory]
        [MemberData(nameof(DecimalIsIntegerData))]
        public void IsInteger_Decimal_Test(decimal value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

    }
}
