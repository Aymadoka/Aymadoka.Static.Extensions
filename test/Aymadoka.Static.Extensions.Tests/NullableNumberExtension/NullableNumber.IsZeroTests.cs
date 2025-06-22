using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_IsZeroTests
    {
        [Theory]
        [InlineData((sbyte)0, true)]
        [InlineData((sbyte)1, false)]
        [InlineData(null, false)]
        public void IsZero_SByte_Test(sbyte? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((byte)0, true)]
        [InlineData((byte)1, false)]
        [InlineData(null, false)]
        public void IsZero_Byte_Test(byte? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((short)0, true)]
        [InlineData((short)1, false)]
        [InlineData(null, false)]
        public void IsZero_Short_Test(short? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((ushort)0, true)]
        [InlineData((ushort)1, false)]
        [InlineData(null, false)]
        public void IsZero_UShort_Test(ushort? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(null, false)]
        public void IsZero_Int_Test(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((uint)0, true)]
        [InlineData((uint)1, false)]
        [InlineData(null, false)]
        public void IsZero_UInt_Test(uint? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0L, true)]
        [InlineData(1L, false)]
        [InlineData(null, false)]
        public void IsZero_Long_Test(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData((ulong)0, true)]
        [InlineData((ulong)1, false)]
        [InlineData(null, false)]
        public void IsZero_ULong_Test(ulong? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0f, true)]
        [InlineData(1f, false)]
        [InlineData(null, false)]
        public void IsZero_Float_Test(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0d, true)]
        [InlineData(1d, false)]
        [InlineData(null, false)]
        public void IsZero_Double_Test(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> GetDecimalTestData()
        {
            yield return new object[] { (decimal?)0m, true };
            yield return new object[] { (decimal?)1m, false };
            yield return new object[] { (decimal?)(-0m), true };
            yield return new object[] { null, false };
        }

        [Theory]
        [MemberData(nameof(GetDecimalTestData))]
        public void IsZero_Decimal_Test(decimal? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }
    }
}
