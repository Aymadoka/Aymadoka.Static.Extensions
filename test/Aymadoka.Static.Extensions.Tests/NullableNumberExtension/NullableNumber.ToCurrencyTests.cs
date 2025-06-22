using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumbNullableNumber_ToCurrencyTestserExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencySByteData()
        {
            yield return new object[] { (sbyte?)123, "¥123.00" };
            yield return new object[] { (sbyte?)-5, "¥-5.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencySByteData))]
        public void ToCurrency_SByte(sbyte? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyByteData()
        {
            yield return new object[] { (byte?)123, "¥123.00" };
            yield return new object[] { (byte?)0, "¥0.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyByteData))]
        public void ToCurrency_Byte(byte? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyShortData()
        {
            yield return new object[] { (short?)12345, "¥12,345.00" };
            yield return new object[] { (short?)-1, "¥-1.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyShortData))]
        public void ToCurrency_Short(short? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyUShortData()
        {
            yield return new object[] { (ushort?)12345, "¥12,345.00" };
            yield return new object[] { (ushort?)0, "¥0.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyUShortData))]
        public void ToCurrency_UShort(ushort? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyIntData()
        {
            yield return new object[] { (int?)123456, "¥123,456.00" };
            yield return new object[] { (int?)-100, "¥-100.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyIntData))]
        public void ToCurrency_Int(int? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyUIntData()
        {
            yield return new object[] { (uint?)123456, "¥123,456.00" };
            yield return new object[] { (uint?)0u, "¥0.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyUIntData))]
        public void ToCurrency_UInt(uint? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyLongData()
        {
            yield return new object[] { (long?)1234567890123L, "¥1,234,567,890,123.00" };
            yield return new object[] { (long?)-1L, "¥-1.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyLongData))]
        public void ToCurrency_Long(long? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyULongData()
        {
            yield return new object[] { (ulong?)1234567890123UL, "¥1,234,567,890,123.00" };
            yield return new object[] { (ulong?)0UL, "¥0.00" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyULongData))]
        public void ToCurrency_ULong(ulong? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyFloatData()
        {
            yield return new object[] { (float?)123.45f, "¥123.45" };
            yield return new object[] { (float?)-0.5f, "¥-0.50" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyFloatData))]
        public void ToCurrency_Float(float? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyDoubleData()
        {
            yield return new object[] { (double?)123.45, "¥123.45" };
            yield return new object[] { (double?)-0.5, "¥-0.50" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyDoubleData))]
        public void ToCurrency_Double(double? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToCurrencyDecimalData()
        {
            yield return new object[] { (decimal?)123.45, "¥123.45" };
            yield return new object[] { (decimal?)-0.5, "¥-0.50" };
            yield return new object[] { null, null };
        }

        [Theory]
        [MemberData(nameof(ToCurrencyDecimalData))]
        public void ToCurrency_Decimal(decimal? value, string expected)
        {
            var result = value.ToCurrency(new CultureInfo("zh-CN"));
            Assert.Equal(expected, result);
        }
    }
}
