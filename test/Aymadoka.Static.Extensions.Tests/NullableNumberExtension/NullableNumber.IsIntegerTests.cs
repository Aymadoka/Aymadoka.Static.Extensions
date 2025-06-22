using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_IsIntegerTests
    {
        [Theory]
        [InlineData((sbyte)0, true)]
        [InlineData((sbyte)1, true)]
        [InlineData((sbyte)-1, true)]
        [InlineData(null, false)]
        public void SByte_IsInteger_Test(sbyte? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((byte)0, true)]
        [InlineData((byte)255, true)]
        [InlineData(null, false)]
        public void Byte_IsInteger_Test(byte? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((short)0, true)]
        [InlineData((short)-32768, true)]
        [InlineData((short)32767, true)]
        [InlineData(null, false)]
        public void Short_IsInteger_Test(short? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((ushort)0, true)]
        [InlineData((ushort)65535, true)]
        [InlineData(null, false)]
        public void UShort_IsInteger_Test(ushort? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(-1, true)]
        [InlineData(123456, true)]
        [InlineData(null, false)]
        public void Int_IsInteger_Test(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((uint)0, true)]
        [InlineData((uint)4294967295, true)]
        [InlineData(null, false)]
        public void UInt_IsInteger_Test(uint? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0L, true)]
        [InlineData(-9223372036854775808L, true)]
        [InlineData(9223372036854775807L, true)]
        [InlineData(null, false)]
        public void Long_IsInteger_Test(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData((ulong)0, true)]
        [InlineData((ulong)18446744073709551615, true)]
        [InlineData(null, false)]
        public void ULong_IsInteger_Test(ulong? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0f, true)]
        [InlineData(1f, true)]
        [InlineData(-1f, true)]
        [InlineData(1.5f, false)]
        [InlineData(float.NaN, false)]
        [InlineData(float.PositiveInfinity, false)]
        [InlineData(float.NegativeInfinity, false)]
        [InlineData(null, false)]
        public void Float_IsInteger_Test(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0d, true)]
        [InlineData(1d, true)]
        [InlineData(-1d, true)]
        [InlineData(1.5d, false)]
        [InlineData(double.NaN, false)]
        [InlineData(double.PositiveInfinity, false)]
        [InlineData(double.NegativeInfinity, false)]
        [InlineData(null, false)]
        public void Double_IsInteger_Test(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalIsIntegerData()
        {
            yield return new object[] { null, false };
            yield return new object[] { (decimal?)10, true };
        }

        [Theory]
        [MemberData(nameof(DecimalIsIntegerData))]
        public void Decimal_IsInteger_Test(decimal? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }
    }
}
