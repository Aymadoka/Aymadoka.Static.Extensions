using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumbNullableNumber_ToCurrencyTestserExtensions
    {
        [Theory]
        [InlineData((sbyte)123, "¥123.00")]
        [InlineData((sbyte)-5, "-¥5.00")]
        [InlineData(null, null)]
        public void ToCurrency_SByte(sbyte? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData((byte)123, "¥123.00")]
        [InlineData((byte)0, "¥0.00")]
        [InlineData(null, null)]
        public void ToCurrency_Byte(byte? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData((short)12345, "¥12,345.00")]
        [InlineData((short)-1, "-¥1.00")]
        [InlineData(null, null)]
        public void ToCurrency_Short(short? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData((ushort)12345, "¥12,345.00")]
        [InlineData((ushort)0, "¥0.00")]
        [InlineData(null, null)]
        public void ToCurrency_UShort(ushort? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123456, "¥123,456.00")]
        [InlineData(-100, "-¥100.00")]
        [InlineData(null, null)]
        public void ToCurrency_Int(int? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123456u, "¥123,456.00")]
        [InlineData(0u, "¥0.00")]
        [InlineData(null, null)]
        public void ToCurrency_UInt(uint? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1234567890123L, "¥1,234,567,890,123.00")]
        [InlineData(-1L, "-¥1.00")]
        [InlineData(null, null)]
        public void ToCurrency_Long(long? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1234567890123UL, "¥1,234,567,890,123.00")]
        [InlineData(0UL, "¥0.00")]
        [InlineData(null, null)]
        public void ToCurrency_ULong(ulong? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.45f, "¥123.45")]
        [InlineData(-0.5f, "-¥0.50")]
        [InlineData(null, null)]
        public void ToCurrency_Float(float? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.45, "¥123.45")]
        [InlineData(-0.5, "-¥0.50")]
        [InlineData(null, null)]
        public void ToCurrency_Double(double? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.45, "¥123.45")]
        [InlineData(-0.5, "-¥0.50")]
        [InlineData(null, null)]
        public void ToCurrency_Decimal(decimal? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }
    }
}
