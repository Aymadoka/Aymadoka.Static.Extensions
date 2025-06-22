using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_ChineseCapitalizedTests
    {
        [Theory]
        [InlineData((byte)0, "零元")]
        [InlineData((byte)1, "壹元整")]
        [InlineData((byte)123, "壹佰贰拾叁元整")]
        public void ChineseCapitalized_Byte(byte value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData((short)0, "零元")]
        [InlineData((short)1, "壹元整")]
        [InlineData((short)-123, "负壹佰贰拾叁元整")]
        public void ChineseCapitalized_Short(short value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData((ushort)0, "零元")]
        [InlineData((ushort)1, "壹元整")]
        [InlineData((ushort)123, "壹佰贰拾叁元整")]
        public void ChineseCapitalized_UShort(ushort value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(0, "零元")]
        [InlineData(1, "壹元整")]
        [InlineData(-123, "负壹佰贰拾叁元整")]
        [InlineData(123456, "壹拾贰万叁仟肆佰伍拾陆元整")]
        public void ChineseCapitalized_Int(int value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData((uint)0, "零元")]
        [InlineData((uint)1, "壹元整")]
        [InlineData((uint)123456, "壹拾贰万叁仟肆佰伍拾陆元整")]
        public void ChineseCapitalized_UInt(uint value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(0L, "零元")]
        [InlineData(1L, "壹元整")]
        [InlineData(-123L, "负壹佰贰拾叁元整")]
        [InlineData(1234567890123L, "壹兆贰仟叁佰肆拾伍亿陆仟柒佰捌拾玖万零壹佰贰拾叁元整")]
        public void ChineseCapitalized_Long(long value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData((ulong)0, "零元")]
        [InlineData((ulong)1, "壹元整")]
        [InlineData((ulong)1234567890123, "壹兆贰仟叁佰肆拾伍亿陆仟柒佰捌拾玖万零壹佰贰拾叁元整")]
        public void ChineseCapitalized_ULong(ulong value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(0f, "零元")]
        [InlineData(1f, "壹元整")]
        [InlineData(123.45f, "壹佰贰拾叁元肆角伍分")]
        [InlineData(-123.00f, "负壹佰贰拾叁元整")]
        public void ChineseCapitalized_Float(float value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(0d, "零元")]
        [InlineData(1d, "壹元整")]
        [InlineData(123.45d, "壹佰贰拾叁元肆角伍分")]
        [InlineData(-123.00d, "负壹佰贰拾叁元整")]
        public void ChineseCapitalized_Double(double value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ChineseCapitalizedDecimalData()
        {
            yield return new object[] { 0d, "零元" };
            yield return new object[] { 1d, "壹元整" };
            yield return new object[] { 123.45d, "壹佰贰拾叁元肆角伍分" };
            yield return new object[] { -123.00d, "负壹佰贰拾叁元整" };
        }

        [Theory]
        [MemberData(nameof(ChineseCapitalizedDecimalData))]
        public void ChineseCapitalized_Decimal(double value, string expected)
        {
            Assert.Equal(expected, ((decimal)value).ChineseCapitalized());
        }
    }
}
