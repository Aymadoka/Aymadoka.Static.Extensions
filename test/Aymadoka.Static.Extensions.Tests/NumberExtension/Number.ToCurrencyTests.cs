using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_ToCurrencyTests
    {
        
        [Theory]
        [InlineData((sbyte)123, "¥123.00")]
        [InlineData((sbyte)-5, "¥-5.00")]
        public void ToCurrency_SByte_DefaultCulture(sbyte value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData((byte)200, "¥200.00")]
        public void ToCurrency_Byte_DefaultCulture(byte value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData((short)1000, "¥1,000.00")]
        [InlineData((short)-1000, "¥-1,000.00")]
        public void ToCurrency_Short_DefaultCulture(short value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData((ushort)65535, "¥65,535.00")]
        public void ToCurrency_UShort_DefaultCulture(ushort value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData(123456, "¥123,456.00")]
        [InlineData(-123456, "¥-123,456.00")]
        public void ToCurrency_Int_DefaultCulture(int value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData(4294967295u, "¥4,294,967,295.00")]
        public void ToCurrency_UInt_DefaultCulture(uint value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData(9223372036854775807L, "¥9,223,372,036,854,775,807.00")]
        [InlineData(-9223372036854775808L, "¥-9,223,372,036,854,775,808.00")]
        public void ToCurrency_Long_DefaultCulture(long value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData(18446744073709551615UL, "¥18,446,744,073,709,551,615.00")]
        public void ToCurrency_ULong_DefaultCulture(ulong value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData(123.456f, "¥123.46")]
        [InlineData(-123.456f, "¥-123.46")]
        public void ToCurrency_Float_DefaultCulture(float value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData(123.456, "¥123.46")]
        [InlineData(-123.456, "¥-123.46")]
        public void ToCurrency_Double_DefaultCulture(double value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalToCurrencyData()
        {
            yield return new object[] { 123.456m, "¥123.46" };
            yield return new object[] { -123.456m, "¥-123.46" };
        }

        [Theory]
        [MemberData(nameof(DecimalToCurrencyData))]
        public void ToCurrency_Decimal_DefaultCulture(decimal value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Fact]
        public void ToCurrency_WithCustomCulture()
        {
            var culture = new CultureInfo("en-US");
            Assert.Equal("$1,234.57", 1234.567m.ToCurrency(culture));
            Assert.Equal("-$1,234.57", (-1234.567m).ToCurrency(culture));
        }
    }
}
