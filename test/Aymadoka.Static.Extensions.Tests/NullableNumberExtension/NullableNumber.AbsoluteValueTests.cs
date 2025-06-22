using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_AbsoluteValueTests
    {
        [Theory]
        [InlineData((sbyte)5, (sbyte)5)]
        [InlineData((sbyte)-5, (sbyte)5)]
        [InlineData(null, null)]
        public void AbsoluteValue_sbyte(sbyte? value, sbyte? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData((byte)5, (short)5)]
        [InlineData((byte)0, (short)0)]
        [InlineData(null, null)]
        public void AbsoluteValue_byte(byte? value, short? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData((short)5, (short)5)]
        [InlineData((short)-5, (short)5)]
        [InlineData(null, null)]
        public void AbsoluteValue_short(short? value, short? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData((ushort)5, 5)]
        [InlineData((ushort)0, 0)]
        [InlineData(null, null)]
        public void AbsoluteValue_ushort(ushort? value, int? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, 5)]
        [InlineData(null, null)]
        public void AbsoluteValue_int(int? value, int? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData((uint)5, 5L)]
        [InlineData((uint)0, 0L)]
        [InlineData(null, null)]
        public void AbsoluteValue_uint(uint? value, long? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(5L, 5L)]
        [InlineData(-5L, 5L)]
        [InlineData(null, null)]
        public void AbsoluteValue_long(long? value, long? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(5.5f, 5.5f)]
        [InlineData(-5.5f, 5.5f)]
        [InlineData(null, null)]
        public void AbsoluteValue_float(float? value, float? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(5.5, 5.5)]
        [InlineData(-5.5, 5.5)]
        [InlineData(null, null)]
        public void AbsoluteValue_double(double? value, double? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalData()
        {
            yield return new object[] { null, null };
            yield return new object[] { (decimal?)5.5, (decimal?)5.5 };
            yield return new object[] { (decimal?)-5.5, (decimal?)5.5 };
        }

        [Theory]
        [MemberData(nameof(DecimalData))]
        public void AbsoluteValue_decimal(decimal? value, decimal? expected)
        {
            var actual = value.AbsoluteValue();
            Assert.Equal(expected, actual);
        }
    }
}
