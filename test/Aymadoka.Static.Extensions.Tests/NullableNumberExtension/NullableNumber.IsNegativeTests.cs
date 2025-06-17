using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_IsNegativeTests
    {
        [Theory]
        [InlineData((sbyte)(-1), true)]
        [InlineData((sbyte)0, false)]
        [InlineData((sbyte)1, false)]
        [InlineData(null, false)]
        public void IsNegative_sbyte_Test(sbyte? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((byte)0, false)]
        [InlineData((byte)1, false)]
        [InlineData(byte.MaxValue, false)]
        [InlineData(null, false)]
        public void IsNegative_byte_Test(byte? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((short)(-1), true)]
        [InlineData((short)0, false)]
        [InlineData((short)1, false)]
        [InlineData(null, false)]
        public void IsNegative_short_Test(short? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((ushort)0, false)]
        [InlineData((ushort)1, false)]
        [InlineData(ushort.MaxValue, false)]
        [InlineData(null, false)]
        public void IsNegative_ushort_Test(ushort? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1, true)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(null, false)]
        public void IsNegative_int_Test(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((uint)0, false)]
        [InlineData((uint)1, false)]
        [InlineData(uint.MaxValue, false)]
        [InlineData(null, false)]
        public void IsNegative_uint_Test(uint? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1L, true)]
        [InlineData(0L, false)]
        [InlineData(1L, false)]
        [InlineData(null, false)]
        public void IsNegative_long_Test(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData((ulong)0, false)]
        [InlineData((ulong)1, false)]
        [InlineData(ulong.MaxValue, false)]
        [InlineData(null, false)]
        public void IsNegative_ulong_Test(ulong? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1.0f, true)]
        [InlineData(0.0f, false)]
        [InlineData(1.0f, false)]
        [InlineData(float.NegativeInfinity, true)]
        [InlineData(float.PositiveInfinity, false)]
        [InlineData(null, false)]
        public void IsNegative_float_Test(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1.0, true)]
        [InlineData(0.0, false)]
        [InlineData(1.0, false)]
        [InlineData(double.NegativeInfinity, true)]
        [InlineData(double.PositiveInfinity, false)]
        [InlineData(null, false)]
        public void IsNegative_double_Test(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> IsNegativeDecimalData()
        {
            yield return new object[] { (decimal?)-1.0, true };
            yield return new object[] { (decimal?)0.0, false };
            yield return new object[] { (decimal?)1.0, false };
            yield return new object[] { (decimal?)null, false };
        }

        [Theory]
        [MemberData(nameof(IsNegativeDecimalData))]
        public void IsNegative_decimal_Test(decimal? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }
    }
}
