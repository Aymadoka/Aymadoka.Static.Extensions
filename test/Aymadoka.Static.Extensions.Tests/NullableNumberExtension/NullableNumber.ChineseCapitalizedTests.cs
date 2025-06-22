using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_ChineseCapitalizedTests
    {
        [Theory]
        [InlineData((byte)123, "壹佰贰拾叁元整")]
        [InlineData(null, null)]
        public void ChineseCapitalized_Byte(byte? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData((short)456, "肆佰伍拾陆元整")]
        [InlineData(null, null)]
        public void ChineseCapitalized_Short(short? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData((ushort)789, "柒佰捌拾玖元整")]
        [InlineData(null, null)]
        public void ChineseCapitalized_UShort(ushort? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(1234, "壹仟贰佰叁拾肆元整")]
        [InlineData(null, null)]
        public void ChineseCapitalized_Int(int? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(5678u, "伍仟陆佰柒拾捌元整")]
        [InlineData(null, null)]
        public void ChineseCapitalized_UInt(uint? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(1234567890123L, "壹兆贰仟叁佰肆拾伍亿陆仟柒佰捌拾玖万零壹佰贰拾叁元整")]
        [InlineData(null, null)]
        public void ChineseCapitalized_Long(long? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(9876543210UL, "玖拾捌亿柒仟陆佰伍拾肆万叁仟贰佰壹拾元整")]
        [InlineData(null, null)]
        public void ChineseCapitalized_ULong(ulong? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(123.45f, "壹佰贰拾叁元肆角伍分")]
        [InlineData(null, null)]
        public void ChineseCapitalized_Float(float? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(6789.01, "陆仟柒佰捌拾玖元零壹分")]
        [InlineData(null, null)]
        public void ChineseCapitalized_Double(double? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalData()
        {
            yield return new object[] { null, null };
            yield return new object[] { (decimal?)123456.78, "壹拾贰万叁仟肆佰伍拾陆元柒角捌分" };
        }

        [Theory]
        [MemberData(nameof(DecimalData))]
        public void ChineseCapitalized_Decimal(decimal? value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }
    }
}
