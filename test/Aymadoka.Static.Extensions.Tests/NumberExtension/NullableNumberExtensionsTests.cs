namespace Aymadoka.Static.NumberExtension
{
    public class NullableNumberExtensionsTests
    {
        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0, true)]      // 零是整数
        [InlineData(1, true)]      // 正整数
        [InlineData(-1, true)]     // 负整数
        [InlineData(1.5, false)]   // 非整数（正小数）
        [InlineData(-1.5, false)]  // 非整数（负小数）
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
        [InlineData(0, false)]     // 零
        [InlineData(1, true)]      // 正整数
        [InlineData(-1, false)]    // 负整数
        [InlineData(1.5, true)]    // 正小数
        [InlineData(-1.5, false)]  // 负小数
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
        [InlineData(0, false)]     // 零
        [InlineData(1, false)]     // 正整数
        [InlineData(-1, true)]     // 负整数
        [InlineData(1.5, false)]   // 正小数
        [InlineData(-1.5, true)]   // 负小数
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
        [InlineData(0, true)]      // 零
        [InlineData(1, false)]     // 正整数
        [InlineData(-1, false)]    // 负整数
        [InlineData(0.0, true)]    // 零（浮点数）
        [InlineData(1.5, false)]   // 非零正小数
        [InlineData(-1.5, false)]  // 非零负小数
        public void IsZero_ShouldReturnExpectedResult_ForNullableDouble(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(null, false)]  // 空值
        [InlineData(0f, true)]     // 零
        [InlineData(1f, false)]    // 正整数
        [InlineData(-1f, false)]   // 负整数
        [InlineData(0.0f, true)]   // 零（浮点数）
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
        [InlineData(0, 0)]          // 零
        [InlineData(1, 1)]          // 正整数
        [InlineData(-1, 1)]         // 负整数
        [InlineData(1.5, 1.5)]      // 正小数
        [InlineData(-1.5, 1.5)]     // 负小数
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
        [InlineData(123.456, 2, 123.46)] // 正数，保留两位小数
        [InlineData(123.451, 2, 123.45)] // 正数，四舍五入
        [InlineData(-123.456, 2, -123.46)] // 负数，保留两位小数
        [InlineData(-123.451, 2, -123.45)] // 负数，四舍五入
        [InlineData(0.0, 2, 0.0)]        // 零，保留两位小数
        [InlineData(123.456, 0, 123.0)]  // 正数，保留整数
        [InlineData(-123.456, 0, -123.0)] // 负数，保留整数
        [InlineData(123.456, 3, 123.456)] // 正数，保留三位小数
        [InlineData(-123.456, 3, -123.456)] // 负数，保留三位小数
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
    }
}
