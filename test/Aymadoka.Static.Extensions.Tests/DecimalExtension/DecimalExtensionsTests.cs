namespace Aymadoka.Static.DecimalExtension
{
    public class DecimalExtensionsTests
    {
        [Theory]
        [InlineData(123.4567, 2, 123.46)] // 四舍五入到两位小数
        [InlineData(123.451, 2, 123.45)] // 四舍五入到两位小数
        [InlineData(123.0, 2, 123.00)] // 已是两位小数
        [InlineData(123.4567, 0, 123)] // 四舍五入到整数
        [InlineData(-123.4567, 2, -123.46)] // 负数四舍五入
        [InlineData(0, 2, 0)] // 零值
        public void Keep_WithSpecifiedDecimalPlaces_ReturnsExpectedResult(decimal input, int decimalPlaces, decimal expected)
        {
            // Act
            var result = input.Keep(decimalPlaces);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Keep_DefaultTwoDecimalPlaces_ReturnsExpectedResult()
        {
            // Arrange
            decimal input = 123.4567m;
            decimal expected = 123.46m;

            // Act
            var result = input.Keep();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.0, true)] // 整数
        [InlineData(0.0, true)] // 零值
        [InlineData(-123.0, true)] // 负整数
        [InlineData(123.45, false)] // 非整数
        [InlineData(-123.45, false)] // 负非整数
        [InlineData(124.0000000000, true)] // 多余小数位但为整数
        [InlineData(123.0000000001, false)] // 接近整数但非整数
        public void IsInteger_ReturnsExpectedResult(decimal input, bool expected)
        {
            // Act
            var result = input.IsInteger();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0.1234, 2, "12.34%")] // 正常小数转换为百分比
        [InlineData(0.1, 0, "10%")] // 无小数位
        [InlineData(0.56789, 3, "56.789%")] // 保留三位小数
        [InlineData(1.0, 2, "100.00%")] // 整数转换为百分比
        [InlineData(-0.25, 1, "-25.0%")] // 负数转换为百分比
        [InlineData(0, 2, "0.00%")] // 零值
        public void ToPercentage_WithSpecifiedDecimalPlaces_ReturnsExpectedResult(decimal input, int decimalPlaces, string expected)
        {
            // Act
            var result = input.ToPercentage(decimalPlaces);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToPercentage_DefaultTwoDecimalPlaces_ReturnsExpectedResult()
        {
            // Arrange
            decimal input = 0.1234m;
            string expected = "12.34%";

            // Act
            var result = input.ToPercentage();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.45, 123.45)] // 正数
        [InlineData(-123.45, 123.45)] // 负数
        [InlineData(0, 0)] // 零值
        [InlineData(-0.0001, 0.0001)] // 接近零的负数
        [InlineData(999999999.99, 999999999.99)] // 大正数
        [InlineData(-999999999.99, 999999999.99)] // 大负数
        public void AbsoluteValue_ReturnsExpectedResult(decimal input, decimal expected)
        {
            // Act
            var result = input.AbsoluteValue();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1234.56, "zh-CN", "¥1,234.56")] // 中文区域格式
        [InlineData(1234.56, "en-US", "$1,234.56")] // 美国区域格式
        [InlineData(-1234.56, "zh-CN", "¥-1,234.56")] // 负数中文区域格式
        [InlineData(0, "zh-CN", "¥0.00")] // 零值中文区域格式
        [InlineData(1234.56, "ja-JP", "￥1,235")] // 日本区域格式（无小数）
        [InlineData(1234.56, "fr-FR", "1 234,56 €")] // 法国区域格式
        public void ToCurrency_WithSpecifiedCulture_ReturnsExpectedResult(decimal input, string culture, string expected)
        {
            // Act
            var result = input.ToCurrency(culture);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToCurrency_DefaultCulture_ReturnsExpectedResult()
        {
            // Arrange
            decimal input = 1234.56m;
            string expected = "¥1,234.56"; // 默认 "zh-CN" 区域

            // Act
            var result = input.ToCurrency();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 1, 10, 5)] // 在范围内
        [InlineData(0, 1, 10, 1)] // 小于最小值
        [InlineData(15, 1, 10, 10)] // 大于最大值
        [InlineData(1, 1, 10, 1)] // 等于最小值
        [InlineData(10, 1, 10, 10)] // 等于最大值
        [InlineData(-5, -10, -1, -5)] // 负数范围内
        [InlineData(-15, -10, -1, -10)] // 小于负数最小值
        [InlineData(0, -10, 10, 0)] // 跨正负范围
        public void Clamp_ReturnsExpectedResult(decimal input, decimal min, decimal max, decimal expected)
        {
            // Act
            var result = input.Clamp(min, max);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 1, 10, true)] // 在范围内
        [InlineData(1, 1, 10, true)] // 等于最小值
        [InlineData(10, 1, 10, true)] // 等于最大值
        [InlineData(0, 1, 10, false)] // 小于最小值
        [InlineData(15, 1, 10, false)] // 大于最大值
        [InlineData(-5, -10, -1, true)] // 负数范围内
        [InlineData(-10, -10, -1, true)] // 等于负数最小值
        [InlineData(-1, -10, -1, true)] // 等于负数最大值
        [InlineData(-15, -10, -1, false)] // 小于负数最小值
        [InlineData(0, -10, 10, true)] // 跨正负范围
        public void IsInRange_ReturnsExpectedResult(decimal input, decimal min, decimal max, bool expected)
        {
            // Act
            var result = input.IsInRange(min, max);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.456, 123)] // 正数小数部分被截断
        [InlineData(-123.456, -123)] // 负数小数部分被截断
        [InlineData(123.0, 123)] // 已是整数
        [InlineData(-123.0, -123)] // 负整数
        [InlineData(0.0, 0)] // 零值
        [InlineData(0.999, 0)] // 接近零的正数
        [InlineData(-0.999, 0)] // 接近零的负数
        public void Truncate_ReturnsExpectedResult(decimal input, decimal expected)
        {
            // Act
            var result = input.Truncate();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(12345.6789, 2, "1.23E+004")] // 正常正数
        [InlineData(-12345.6789, 3, "-1.235E+004")] // 负数
        [InlineData(0.00012345, 4, "1.2345E-004")] // 小数
        [InlineData(0, 2, "0.00E+000")] // 零值
        [InlineData(12345678901234567890.0, 1, "1.2E+019")] // 大数
        [InlineData(-0.00000000012345, 5, "-1.23450E-010")] // 非常小的负数
        public void ToScientificNotation_ReturnsExpectedResult(decimal input, int decimalPlaces, string expected)
        {
            // Act
            var result = input.ToScientificNotation(decimalPlaces);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToScientificNotation_DefaultDecimalPlaces_ReturnsExpectedResult()
        {
            // Arrange
            decimal input = 12345.6789m;
            string expected = "1.23E+004"; // 默认保留两位小数

            // Act
            var result = input.ToScientificNotation();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.45, true)] // 正数
        [InlineData(0, false)] // 零值
        [InlineData(-123.45, false)] // 负数
        [InlineData(0.0001, true)] // 接近零的正数
        [InlineData(-0.0001, false)] // 接近零的负数
        public void IsPositive_ReturnsExpectedResult(decimal input, bool expected)
        {
            // Act
            var result = input.IsPositive();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-123.45, true)] // 负数
        [InlineData(0, false)] // 零值
        [InlineData(123.45, false)] // 正数
        [InlineData(-0.0001, true)] // 接近零的负数
        [InlineData(0.0001, false)] // 接近零的正数
        public void IsNegative_ReturnsExpectedResult(decimal input, bool expected)
        {
            // Act
            var result = input.IsNegative();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, true)] // 零值
        [InlineData(-0.00, true)] // 显式零值
        [InlineData(123.45, false)] // 正数
        [InlineData(-123.45, false)] // 负数
        [InlineData(0.0001, false)] // 接近零的正数
        [InlineData(-0.0001, false)] // 接近零的负数
        public void IsZero_ReturnsExpectedResult(decimal input, bool expected)
        {
            // Act
            var result = input.IsZero();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.45, "壹佰贰拾叁元肆角伍分")] // 正常正数
        [InlineData(0, "零元")] // 零值
        [InlineData(-123.00, "负壹佰贰拾叁元整")] // 负整数
        [InlineData(1000.01, "壹仟元零壹分")] // 带零的正数
        [InlineData(-0.56, "负伍角陆分")] // 负小数
        [InlineData(1000000, "壹佰万元整")] // 大整数
        [InlineData(0.10, "壹角")] // 仅有角
        [InlineData(0.01, "壹分")] // 仅有分
        public void ChineseCapitalized_ReturnsExpectedResult(decimal input, string expected)
        {
            // Act
            var result = input.ChineseCapitalized();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.456, "壹佰贰拾叁元肆角陆分")] // 超过两位小数，截断到两位
        [InlineData(-123.456, "负壹佰贰拾叁元肆角陆分")] // 负数超过两位小数，截断到两位
        [InlineData(0.789, "柒角玖分")] // 小数部分超过两位，截断到两位
        [InlineData(-0.789, "负柒角玖分")] // 负小数部分超过两位
        [InlineData(123.000456, "壹佰贰拾叁元整")] // 小数部分无效，视为整数
        [InlineData(-123.000456, "负壹佰贰拾叁元整")] // 负数小数部分无效
        public void ChineseCapitalized_WithMoreDecimalPlaces_ReturnsExpectedResult(decimal input, string expected)
        {
            // Act
            var result = input.ChineseCapitalized();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
