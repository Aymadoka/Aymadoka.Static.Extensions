using Aymadoka.Static.NullableNumberExtension;
using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public class NullableNumberExtensionsTests 
    {
        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0d, true)]      // 零是整数
        [InlineData(1d, true)]      // 正整数
        [InlineData(-1d, true)]     // 负整数
        [InlineData(1.5d, false)]   // 非整数（正小数）
        [InlineData(-1.5d, false)]  // 非整数（负小数）
        public void IsInteger_ShouldReturnExpectedResult_ForNullableDouble(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0f, true)]     // 零是整数
        [InlineData(1f, true)]     // 正整数
        [InlineData(-1f, true)]    // 负整数
        [InlineData(1.5f, false)]  // 非整数（正小数）
        [InlineData(-1.5f, false)] // 非整数（负小数）
        public void IsInteger_ShouldReturnExpectedResult_ForNullableFloat(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0, true)]      // 零是整数
        [InlineData(1, true)]      // 正整数
        [InlineData(-1, true)]     // 负整数
        public void IsInteger_ShouldReturnExpectedResult_ForNullableInt(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0L, true)]     // 零是整数
        [InlineData(1L, true)]     // 正整数
        [InlineData(-1L, true)]    // 负整数
        public void IsInteger_ShouldReturnExpectedResult_ForNullableLong(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0d, false)]     // 零
        [InlineData(1d, true)]      // 正整数
        [InlineData(-1d, false)]    // 负整数
        [InlineData(1.5d, true)]    // 正小数
        [InlineData(-1.5d, false)]  // 负小数
        public void IsPositive_ShouldReturnExpectedResult_ForNullableDouble(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0f, false)]    // 零
        [InlineData(1f, true)]     // 正整数
        [InlineData(-1f, false)]   // 负整数
        [InlineData(1.5f, true)]   // 正小数
        [InlineData(-1.5f, false)] // 负小数
        public void IsPositive_ShouldReturnExpectedResult_ForNullableFloat(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0, false)]     // 零
        [InlineData(1, true)]      // 正整数
        [InlineData(-1, false)]    // 负整数
        public void IsPositive_ShouldReturnExpectedResult_ForNullableInt(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0L, false)]    // 零
        [InlineData(1L, true)]     // 正整数
        [InlineData(-1L, false)]   // 负整数
        public void IsPositive_ShouldReturnExpectedResult_ForNullableLong(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0d, false)]     // 零
        [InlineData(1d, false)]     // 正整数
        [InlineData(-1d, true)]     // 负整数
        [InlineData(1.5d, false)]   // 正小数
        [InlineData(-1.5d, true)]   // 负小数
        public void IsNegative_ShouldReturnExpectedResult_ForNullableDouble(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0f, false)]    // 零
        [InlineData(1f, false)]    // 正整数
        [InlineData(-1f, true)]    // 负整数
        [InlineData(1.5f, false)]  // 正小数
        [InlineData(-1.5f, true)]  // 负小数
        public void IsNegative_ShouldReturnExpectedResult_ForNullableFloat(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0, false)]     // 零
        [InlineData(1, false)]     // 正整数
        [InlineData(-1, true)]     // 负整数
        public void IsNegative_ShouldReturnExpectedResult_ForNullableInt(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0L, false)]    // 零
        [InlineData(1L, false)]    // 正整数
        [InlineData(-1L, true)]    // 负整数
        public void IsNegative_ShouldReturnExpectedResult_ForNullableLong(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0.0d, true)]      // 零
        [InlineData(1d, false)]     // 正整数
        [InlineData(-1d, false)]    // 负整数
        [InlineData(1.5d, false)]   // 非零正小数
        [InlineData(-1.5d, false)]  // 非零负小数
        public void IsZero_ShouldReturnExpectedResult_ForNullableDouble(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0f, true)]     // 零
        [InlineData(1f, false)]    // 正整数
        [InlineData(-1f, false)]   // 负整数
        [InlineData(1.5f, false)]  // 非零正小数
        [InlineData(-1.5f, false)] // 非零负小数
        public void IsZero_ShouldReturnExpectedResult_ForNullableFloat(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0, true)]      // 零
        [InlineData(1, false)]     // 正整数
        [InlineData(-1, false)]    // 负整数
        public void IsZero_ShouldReturnExpectedResult_ForNullableInt(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0L, true)]     // 零
        [InlineData(1L, false)]    // 正整数
        [InlineData(-1L, false)]   // 负整数
        public void IsZero_ShouldReturnExpectedResult_ForNullableLong(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(null, null)]    // 空值
        [InlineData(0d, 0)]          // 零
        [InlineData(1d, 1)]          // 正整数
        [InlineData(-1d, 1)]         // 负整数
        [InlineData(1.5d, 1.5)]      // 正小数
        [InlineData(-1.5d, 1.5)]     // 负小数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForNullableDouble(double? value, double? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(null, null)]    // 空值
        [InlineData(0f, 0f)]        // 零
        [InlineData(1f, 1f)]        // 正整数
        [InlineData(-1f, 1f)]       // 负整数
        [InlineData(1.5f, 1.5f)]    // 正小数
        [InlineData(-1.5f, 1.5f)]   // 负小数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForNullableFloat(float? value, float? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(null, null)]    // 空值
        [InlineData(0, 0)]          // 零
        [InlineData(1, 1)]          // 正整数
        [InlineData(-1, 1)]         // 负整数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForNullableInt(int? value, int? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(null, null)]    // 空值
        [InlineData(0L, 0L)]        // 零
        [InlineData(1L, 1L)]        // 正整数
        [InlineData(-1L, 1L)]       // 负整数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForNullableLong(long? value, long? expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(null, 2, null)]       // 空值
        [InlineData(123.456d, 2, 123.46d)] // 正数，保留两位小数
        [InlineData(123.451d, 2, 123.45d)] // 正数，四舍五入
        [InlineData(-123.456d, 2, -123.46d)] // 负数，保留两位小数
        [InlineData(-123.451d, 2, -123.45d)] // 负数，四舍五入
        [InlineData(0.0d, 2, 0.0d)]        // 零，保留两位小数
        [InlineData(123.456d, 0, 123.0d)]  // 正数，保留整数
        [InlineData(-123.456d, 0, -123.0d)] // 负数，保留整数
        [InlineData(123.456d, 3, 123.456d)] // 正数，保留三位小数
        [InlineData(-123.456d, 3, -123.456d)] // 负数，保留三位小数
        public void Keep_ShouldReturnExpectedResult_ForNullableDouble(double? value, int decimalPlaces, double? expected)
        {
            Assert.Equal(expected, value.Keep(decimalPlaces));
        }

        [Theory]
        [InlineData(null, 2, null)]       // 空值
        [InlineData(123.456f, 2, 123.46f)] // 正数，保留两位小数
        [InlineData(123.451f, 2, 123.45f)] // 正数，四舍五入
        [InlineData(-123.456f, 2, -123.46f)] // 负数，保留两位小数
        [InlineData(-123.451f, 2, -123.45f)] // 负数，四舍五入
        [InlineData(0.0f, 2, 0.0f)]        // 零，保留两位小数
        [InlineData(123.456f, 0, 123.0f)]  // 正数，保留整数
        [InlineData(-123.456f, 0, -123.0f)] // 负数，保留整数
        [InlineData(123.456f, 3, 123.456f)] // 正数，保留三位小数
        [InlineData(-123.456f, 3, -123.456f)] // 负数，保留三位小数
        public void Keep_ShouldReturnExpectedResult_ForNullableFloat(float? value, int decimalPlaces, float? expected)
        {
            Assert.Equal(expected, value.Keep(decimalPlaces));
        }

        [Theory]
        [InlineData(null, 2, null)] // 空值
        [InlineData(0.1234d, 2, "12.34%")] // 正数，保留两位小数
        [InlineData(0.1234d, 0, "12%")] // 正数，保留整数
        [InlineData(-0.1234d, 2, "-12.34%")] // 负数，保留两位小数
        [InlineData(-0.1234d, 0, "-12%")] // 负数，保留整数
        [InlineData(0.0d, 2, "0.00%")] // 零，保留两位小数
        [InlineData(1.0d, 2, "100.00%")] // 1 转换为百分比
        [InlineData(0.56789d, 3, "56.789%")] // 保留三位小数
        public void ToPercentage_ShouldReturnExpectedResult_DefaultCulture(double? value, int decimalPlaces, string? expected)
        {
            Assert.Equal(expected, value.ToPercentage(decimalPlaces));
        }

        [Theory]
        [InlineData(null, 2, null)] // 空值
        [InlineData(0.1234d, 2, "12,34%")] // 正数，保留两位小数（德语文化）
        [InlineData(-0.1234d, 2, "-12,34%")] // 负数，保留两位小数（德语文化）
        [InlineData(0.0d, 2, "0,00%")] // 零，保留两位小数（德语文化）
        [InlineData(1.0d, 2, "100,00%")] // 1 转换为百分比（德语文化）
        public void ToPercentage_ShouldReturnExpectedResult_SpecificCulture(double? value, int decimalPlaces, string? expected)
        {
            var germanCulture = new CultureInfo("de-DE");
            Assert.Equal(expected, value.ToPercentage(decimalPlaces, germanCulture));
        }

        [Theory]
        [InlineData(null, null, null)] // 空值
        [InlineData(1234.56d, "zh-CN", "¥1,234.56")] // 正数，中文文化
        [InlineData(-1234.56d, "zh-CN", "-¥1,234.56")] // 负数，中文文化
        [InlineData(0.0d, "zh-CN", "¥0.00")] // 零，中文文化
        [InlineData(1234.56d, "en-US", "$1,234.56")] // 正数，美国文化
        [InlineData(-1234.56d, "en-US", "($1,234.56)")] // 负数，美国文化
        [InlineData(0.0d, "en-US", "$0.00")] // 零，美国文化
        [InlineData(1234.56d, "de-DE", "1.234,56 €")] // 正数，德国文化
        [InlineData(-1234.56d, "de-DE", "-1.234,56 €")] // 负数，德国文化
        [InlineData(0.0d, "de-DE", "0,00 €")] // 零，德国文化
        public void ToCurrency_ShouldReturnExpectedResult(double? value, string? cultureName, string? expected)
        {
            var culture = cultureName != null ? new CultureInfo(cultureName) : null;
            Assert.Equal(expected, value.ToCurrency(culture));
        }

        [Theory]
        [InlineData(null, 2, null)] // 空值
        [InlineData(1234.5678d, 2, "1.23E+03")] // 正数，保留两位小数
        [InlineData(1234.5678d, 3, "1.235E+03")] // 正数，保留三位小数
        [InlineData(-1234.5678d, 2, "-1.23E+03")] // 负数，保留两位小数
        [InlineData(-1234.5678d, 3, "-1.235E+03")] // 负数，保留三位小数
        [InlineData(0.0d, 2, "0.00E+00")] // 零，保留两位小数
        [InlineData(1.0d, 2, "1.00E+00")] // 1 转换为科学计数法
        [InlineData(0.0001234d, 2, "1.23E-04")] // 小数，保留两位小数
        public void ToScientificNotation_ShouldReturnExpectedResult_DefaultCulture(double? value, int decimalPlaces, string? expected)
        {
            Assert.Equal(expected, value.ToScientificNotation(decimalPlaces));
        }

        [Theory]
        [InlineData(null, 2, null)] // 空值
        [InlineData(1234.5678d, 2, "1,23E+03")] // 正数，保留两位小数（德语文化）
        [InlineData(-1234.5678d, 2, "-1,23E+03")] // 负数，保留两位小数（德语文化）
        [InlineData(0.0d, 2, "0,00E+00")] // 零，保留两位小数（德语文化）
        [InlineData(1.0d, 2, "1,00E+00")] // 1 转换为科学计数法（德语文化）
        [InlineData(0.0001234d, 2, "1,23E-04")] // 小数，保留两位小数（德语文化）
        public void ToScientificNotation_ShouldReturnExpectedResult_SpecificCulture(double? value, int decimalPlaces, string? expected)
        {
            var germanCulture = new CultureInfo("de-DE");
            Assert.Equal(expected, value.ToScientificNotation(decimalPlaces, germanCulture));
        }

        [Theory]
        [InlineData(null, null)] // 空值
        [InlineData(0.0d, "零元")] // 零
        [InlineData(123.45d, "壹佰贰拾叁元肆角伍分")] // 正数（小数）
        [InlineData(-123.45d, "负壹佰贰拾叁元肆角伍分")] // 负数（小数）
        [InlineData(123.00d, "壹佰贰拾叁元整")] // 正数（整数）
        [InlineData(-123.00d, "负壹佰贰拾叁元整")] // 负数（整数）
        [InlineData(1000.01d, "壹仟元零壹分")] // 边界值（千位）
        [InlineData(-1000.01d, "负壹仟元零壹分")] // 边界值（负千位）
        [InlineData(1000000.00d, "壹佰万元整")] // 边界值（百万）
        [InlineData(-1000000.00d, "负壹佰万元整")] // 边界值（负百万）
        public void ChineseCapitalized_ShouldReturnExpectedResult_ForNullableDouble(double? value, string? expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(null, null)] // 空值
        [InlineData(0.0f, "零元")] // 零
        [InlineData(123.45f, "壹佰贰拾叁元肆角伍分")] // 正数（小数）
        [InlineData(-123.45f, "负壹佰贰拾叁元肆角伍分")] // 负数（小数）
        [InlineData(123.00f, "壹佰贰拾叁元整")] // 正数（整数）
        [InlineData(-123.00f, "负壹佰贰拾叁元整")] // 负数（整数）
        [InlineData(1000.01f, "壹仟元零壹分")] // 边界值（千位）
        [InlineData(-1000.01f, "负壹仟元零壹分")] // 边界值（负千位）
        [InlineData(1000000.00f, "壹佰万元整")] // 边界值（百万）
        [InlineData(-1000000.00f, "负壹佰万元整")] // 边界值（负百万）
        public void ChineseCapitalized_ShouldReturnExpectedResult_ForNullableFloat(float? value, string? expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }
    }
}
