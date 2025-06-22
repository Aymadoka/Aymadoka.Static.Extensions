using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_IsPositiveTests
    {
        [Theory]
        [InlineData((sbyte)1, true)]
        [InlineData((sbyte)0, false)]
        [InlineData((sbyte)-1, false)]
        [InlineData(null, false)]
        public void IsPositive_sbyte_Test(sbyte? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((byte)1, true)]
        [InlineData((byte)0, false)]
        [InlineData(null, false)]
        public void IsPositive_byte_Test(byte? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((short)1, true)]
        [InlineData((short)0, false)]
        [InlineData((short)-1, false)]
        [InlineData(null, false)]
        public void IsPositive_short_Test(short? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((ushort)1, true)]
        [InlineData((ushort)0, false)]
        [InlineData(null, false)]
        public void IsPositive_ushort_Test(ushort? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(-1, false)]
        [InlineData(null, false)]
        public void IsPositive_int_Test(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((uint)1, true)]
        [InlineData((uint)0, false)]
        [InlineData(null, false)]
        public void IsPositive_uint_Test(uint? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1L, true)]
        [InlineData(0L, false)]
        [InlineData(-1L, false)]
        [InlineData(null, false)]
        public void IsPositive_long_Test(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData((ulong)1, true)]
        [InlineData((ulong)0, false)]
        [InlineData(null, false)]
        public void IsPositive_ulong_Test(ulong? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1.0f, true)]
        [InlineData(0.0f, false)]
        [InlineData(-1.0f, false)]
        [InlineData(null, false)]
        public void IsPositive_float_Test(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1.0, true)]
        [InlineData(0.0, false)]
        [InlineData(-1.0, false)]
        [InlineData(null, false)]
        public void IsPositive_double_Test(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> IsPositiveDecimalData()
        {
            yield return new object[] { (decimal?)1.0, true };
            yield return new object[] { (decimal?)0.0, false };
            yield return new object[] { (decimal?)-1.0, false };
            yield return new object[] { null, false };
        }

        [Theory]
        [MemberData(nameof(IsPositiveDecimalData))]
        public void IsPositive_decimal_Test(decimal? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }
    }
}
