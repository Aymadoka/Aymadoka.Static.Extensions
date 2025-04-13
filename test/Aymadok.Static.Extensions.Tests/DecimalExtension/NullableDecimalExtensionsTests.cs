namespace Aymadok.Static.DecimalExtension
{
    public class NullableDecimalExtensionsTests
    {
        [Fact]
        public void Keep_DefaultTwoDecimalPlaces_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.Keep();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(123.4567, 123.46)] // 默认保留两位小数
        [InlineData(-123.456, -123.46)] // 负数默认保留两位小数
        [InlineData(0, 0)]             // 零值
        [InlineData(123.0, 123.00)]    // 已经是两位小数
        public void Keep_DefaultTwoDecimalPlaces_ReturnsExpected(decimal input, decimal expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.Keep();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.4567, 2, 123.46)] // 四舍五入到两位小数
        [InlineData(123.451, 2, 123.45)]  // 四舍五入到两位小数
        [InlineData(123.0, 2, 123.00)]    // 已经是两位小数
        [InlineData(-123.456, 2, -123.46)] // 负数四舍五入
        [InlineData(0, 2, 0)]             // 零值
        [InlineData(123.4567, 0, 123)]    // 四舍五入到整数
        [InlineData(123.4567, 3, 123.457)] // 四舍五入到三位小数
        public void Keep_WithDecimalPlaces_ReturnsExpected(decimal input, int decimalPlaces, decimal expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.Keep(decimalPlaces);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(123.0, true)]    // 整数
        [InlineData(123.45, false)] // 非整数
        [InlineData(-123.0, true)]  // 负整数
        [InlineData(-123.45, false)] // 负非整数
        [InlineData(0, true)]       // 零值
        public void IsInteger_ReturnsExpected(decimal input, bool expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.IsInteger();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsInteger_WithNullInput_ReturnsFalse()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.IsInteger();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(0.1234, 2, "12.34%")]  // 正常百分比转换，保留两位小数
        [InlineData(0.1, 0, "10%")]       // 保留零位小数
        [InlineData(0.56789, 3, "56.789%")] // 保留三位小数
        [InlineData(-0.1234, 2, "-12.34%")] // 负数百分比
        [InlineData(0, 2, "0.00%")]       // 零值
        public void ToPercentage_WithDecimalPlaces_ReturnsExpected(decimal input, int decimalPlaces, string expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.ToPercentage(decimalPlaces);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0.1234, "12.34%")]  // 默认保留两位小数
        [InlineData(-0.1234, "-12.34%")] // 负数默认保留两位小数
        [InlineData(0, "0.00%")]       // 零值
        public void ToPercentage_DefaultTwoDecimalPlaces_ReturnsExpected(decimal input, string expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.ToPercentage();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToPercentage_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.ToPercentage();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(123.45, 123.45)]  // 正数
        [InlineData(-123.45, 123.45)] // 负数
        [InlineData(0, 0)]            // 零值
        public void AbsoluteValue_ReturnsExpected(decimal input, decimal expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.AbsoluteValue();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AbsoluteValue_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.AbsoluteValue();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(1234.56, "zh-CN", "¥1,234.56")] // 默认中文货币格式
        [InlineData(1234.56, "en-US", "$1,234.56")] // 英文货币格式
        [InlineData(-1234.56, "zh-CN", "¥-1,234.56")] // 负数中文货币格式
        [InlineData(0, "zh-CN", "¥0.00")] // 零值中文货币格式
        public void ToCurrency_WithCulture_ReturnsExpected(decimal input, string culture, string expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.ToCurrency(culture);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1234.56, "¥1,234.56")] // 默认中文货币格式
        [InlineData(-1234.56, "¥-1,234.56")] // 负数默认中文货币格式
        [InlineData(0, "¥0.00")] // 零值默认中文货币格式
        public void ToCurrency_DefaultCulture_ReturnsExpected(decimal input, string expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.ToCurrency();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToCurrency_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.ToCurrency();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(5, 1, 10, 5)]    // 在范围内
        [InlineData(0, 1, 10, 1)]    // 小于最小值
        [InlineData(15, 1, 10, 10)]  // 大于最大值
        [InlineData(1, 1, 10, 1)]    // 等于最小值
        [InlineData(10, 1, 10, 10)]  // 等于最大值
        public void Clamp_ReturnsExpected(decimal input, decimal min, decimal max, decimal expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.Clamp(min, max);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Clamp_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.Clamp(1, 10);

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(5, 1, 10, true)]    // 在范围内
        [InlineData(0, 1, 10, false)]  // 小于最小值
        [InlineData(15, 1, 10, false)] // 大于最大值
        [InlineData(1, 1, 10, true)]   // 等于最小值
        [InlineData(10, 1, 10, true)]  // 等于最大值
        public void IsInRange_ReturnsExpected(decimal input, decimal min, decimal max, bool expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.IsInRange(min, max);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsInRange_WithNullInput_ReturnsFalse()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.IsInRange(1, 10);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(123.456, 123)]   // 正数截断
        [InlineData(-123.456, -123)] // 负数截断
        [InlineData(0, 0)]           // 零值
        [InlineData(123.0, 123)]     // 已经是整数
        public void Truncate_ReturnsExpected(decimal input, decimal expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.Truncate();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Truncate_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.Truncate();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(12345.6789, 2, "1.23E+004")]  // 正数科学计数法，保留两位小数
        [InlineData(0.00012345, 3, "1.23E-004")] // 小数科学计数法，保留三位小数
        [InlineData(-98765.4321, 1, "-9.88E+004")] // 负数科学计数法，保留一位小数
        [InlineData(0, 2, "0.00E+000")]           // 零值科学计数法
        public void ToScientificNotation_ReturnsExpected(decimal input, int decimalPlaces, string expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.ToScientificNotation(decimalPlaces);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToScientificNotation_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.ToScientificNotation();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(123.45, true)]   // 正数
        [InlineData(-123.45, false)] // 负数
        [InlineData(0, false)]       // 零值
        public void IsPositive_ReturnsExpected(decimal input, bool expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.IsPositive();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsPositive_WithNullInput_ReturnsFalse()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.IsPositive();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(-123.45, true)]  // 负数
        [InlineData(123.45, false)]  // 正数
        [InlineData(0, false)]       // 零值
        public void IsNegative_ReturnsExpected(decimal input, bool expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.IsNegative();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsNegative_WithNullInput_ReturnsFalse()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.IsNegative();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(0, true)]        // 零值
        [InlineData(123.45, false)]  // 正数
        [InlineData(-123.45, false)] // 负数
        public void IsZero_ReturnsExpected(decimal input, bool expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.IsZero();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsZero_WithNullInput_ReturnsFalse()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.IsZero();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(123.45, "壹佰贰拾叁元肆角伍分")]  // 正数
        [InlineData(-123.00, "负壹佰贰拾叁元整")]     // 负数
        [InlineData(0, "零元")]                      // 零值
        [InlineData(1000.01, "壹仟元零壹分")]         // 边界值
        public void ChineseCapitalized_ReturnsExpected(decimal input, string expected)
        {
            // Convert input to nullable decimal
            decimal? nullableInput = input;

            // Act
            var result = nullableInput.ChineseCapitalized();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ChineseCapitalized_WithNullInput_ReturnsNull()
        {
            // Arrange
            decimal? nullableInput = null;

            // Act
            var result = nullableInput.ChineseCapitalized();

            // Assert
            Assert.Null(result);
        }
    }
}
