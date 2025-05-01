using System.Globalization;
using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public class NumberExtensionsTests 
    {
        [Theory]
        [InlineData(0, true)]  // 零是整数
        [InlineData(1, true)]  // 正整数
        [InlineData(-1, true)] // 负整数
        [InlineData(1.5, false)] // 非整数（正小数）
        [InlineData(-1.5, false)] // 非整数（负小数）
        public void IsInteger_ShouldReturnExpectedResult_ForDouble(double value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0, true)]  // 零是整数
        [InlineData(1, true)]  // 正整数
        [InlineData(-1, true)] // 负整数
        [InlineData(1.5f, false)] // 非整数（正小数）
        [InlineData(-1.5f, false)] // 非整数（负小数）
        public void IsInteger_ShouldReturnExpectedResult_ForFloat(float value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0, true)]  // 零是整数
        [InlineData(1, true)]  // 正整数
        [InlineData(-1, true)] // 负整数
        public void IsInteger_ShouldReturnExpectedResult_ForInt(int value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData(0L, true)]  // 零是整数
        [InlineData(1L, true)]  // 正整数
        [InlineData(-1L, true)] // 负整数
        public void IsInteger_ShouldReturnExpectedResult_ForLong(long value, bool expected)
        {
            Assert.Equal(expected, value.IsInteger());
        }

        [Theory]
        [InlineData("0", true)]  // 零是整数
        [InlineData("1", true)]  // 正整数
        [InlineData("-1", true)] // 负整数
        public void IsInteger_ShouldReturnExpectedResult_ForBigInteger(string value, bool expected)
        {
            var bigInteger = BigInteger.Parse(value);
            Assert.Equal(expected, bigInteger.IsInteger());
        }

        [Theory]
        [InlineData(1d, true)]  // 正整数
        [InlineData(0d, false)] // 零
        [InlineData(-1d, false)] // 负整数
        [InlineData(1.5d, true)] // 正小数
        [InlineData(-1.5d, false)] // 负小数
        public void IsPositive_ShouldReturnExpectedResult_ForDouble(double value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1, true)]  // 正整数
        [InlineData(0, false)] // 零
        [InlineData(-1, false)] // 负整数
        [InlineData(1.5f, true)] // 正小数
        [InlineData(-1.5f, false)] // 负小数
        public void IsPositive_ShouldReturnExpectedResult_ForFloat(float value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1, true)]  // 正整数
        [InlineData(0, false)] // 零
        [InlineData(-1, false)] // 负整数
        public void IsPositive_ShouldReturnExpectedResult_ForInt(int value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData(1L, true)]  // 正整数
        [InlineData(0L, false)] // 零
        [InlineData(-1L, false)] // 负整数
        public void IsPositive_ShouldReturnExpectedResult_ForLong(long value, bool expected)
        {
            Assert.Equal(expected, value.IsPositive());
        }

        [Theory]
        [InlineData("1", true)]  // 正整数
        [InlineData("0", false)] // 零
        [InlineData("-1", false)] // 负整数
        public void IsPositive_ShouldReturnExpectedResult_ForBigInteger(string value, bool expected)
        {
            var bigInteger = BigInteger.Parse(value);
            Assert.Equal(expected, bigInteger.IsPositive());
        }

        [Theory]
        [InlineData(-1, true)]  // 负整数
        [InlineData(0, false)]  // 零
        [InlineData(1, false)]  // 正整数
        [InlineData(-1.5, true)] // 负小数
        [InlineData(1.5, false)] // 正小数
        public void IsNegative_ShouldReturnExpectedResult_ForDouble(double value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1, true)]  // 负整数
        [InlineData(0, false)]  // 零
        [InlineData(1, false)]  // 正整数
        [InlineData(-1.5f, true)] // 负小数
        [InlineData(1.5f, false)] // 正小数
        public void IsNegative_ShouldReturnExpectedResult_ForFloat(float value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1, true)]  // 负整数
        [InlineData(0, false)]  // 零
        [InlineData(1, false)]  // 正整数
        public void IsNegative_ShouldReturnExpectedResult_ForInt(int value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData(-1L, true)]  // 负整数
        [InlineData(0L, false)]  // 零
        [InlineData(1L, false)]  // 正整数
        public void IsNegative_ShouldReturnExpectedResult_ForLong(long value, bool expected)
        {
            Assert.Equal(expected, value.IsNegative());
        }

        [Theory]
        [InlineData("-1", true)]  // 负整数
        [InlineData("0", false)]  // 零
        [InlineData("1", false)]  // 正整数
        public void IsNegative_ShouldReturnExpectedResult_ForBigInteger(string value, bool expected)
        {
            var bigInteger = BigInteger.Parse(value);
            Assert.Equal(expected, bigInteger.IsNegative());
        }

        [Theory]
        [InlineData(0, true)]  // 零
        [InlineData(1, false)] // 正整数
        [InlineData(-1, false)] // 负整数
        [InlineData(0.0, true)] // 零（浮点数）
        [InlineData(1.5, false)] // 非零正小数
        [InlineData(-1.5, false)] // 非零负小数
        public void IsZero_ShouldReturnExpectedResult_ForDouble(double value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0, true)]  // 零
        [InlineData(1, false)] // 正整数
        [InlineData(-1, false)] // 负整数
        [InlineData(0.0f, true)] // 零（浮点数）
        [InlineData(1.5f, false)] // 非零正小数
        [InlineData(-1.5f, false)] // 非零负小数
        public void IsZero_ShouldReturnExpectedResult_ForFloat(float value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0, true)]  // 零
        [InlineData(1, false)] // 正整数
        [InlineData(-1, false)] // 负整数
        public void IsZero_ShouldReturnExpectedResult_ForInt(int value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData(0L, true)]  // 零
        [InlineData(1L, false)] // 正整数
        [InlineData(-1L, false)] // 负整数
        public void IsZero_ShouldReturnExpectedResult_ForLong(long value, bool expected)
        {
            Assert.Equal(expected, value.IsZero());
        }

        [Theory]
        [InlineData("0", true)]  // 零
        [InlineData("1", false)] // 正整数
        [InlineData("-1", false)] // 负整数
        public void IsZero_ShouldReturnExpectedResult_ForBigInteger(string value, bool expected)
        {
            var bigInteger = BigInteger.Parse(value);
            Assert.Equal(expected, bigInteger.IsZero());
        }

        [Theory]
        [InlineData(48, 18, 6)]  // 正整数
        [InlineData(18, 48, 6)]  // 参数顺序交换
        [InlineData(0, 5, 5)]    // 一个参数为零
        [InlineData(5, 0, 5)]    // 一个参数为零（交换顺序）
        [InlineData(0, 0, 0)]    // 两个参数为零
        [InlineData(-48, 18, 6)] // 一个负数
        [InlineData(48, -18, 6)] // 一个负数（交换顺序）
        [InlineData(-48, -18, 6)]// 两个负数
        public void GreatestCommonDivisor_ShouldReturnExpectedResult_ForInt(int number1, int number2, int expected)
        {
            Assert.Equal(expected, number1.GreatestCommonDivisor(number2));
        }

        [Theory]
        [InlineData(48L, 18L, 6L)]  // 正整数
        [InlineData(18L, 48L, 6L)]  // 参数顺序交换
        [InlineData(0L, 5L, 5L)]    // 一个参数为零
        [InlineData(5L, 0L, 5L)]    // 一个参数为零（交换顺序）
        [InlineData(0L, 0L, 0L)]    // 两个参数为零
        [InlineData(-48L, 18L, 6L)] // 一个负数
        [InlineData(48L, -18L, 6L)] // 一个负数（交换顺序）
        [InlineData(-48L, -18L, 6L)]// 两个负数
        public void GreatestCommonDivisor_ShouldReturnExpectedResult_ForLong(long number1, long number2, long expected)
        {
            Assert.Equal(expected, number1.GreatestCommonDivisor(number2));
        }

        [Theory]
        [InlineData("48", "18", "6")]  // 正整数
        [InlineData("18", "48", "6")]  // 参数顺序交换
        [InlineData("0", "5", "5")]    // 一个参数为零
        [InlineData("5", "0", "5")]    // 一个参数为零（交换顺序）
        [InlineData("0", "0", "0")]    // 两个参数为零
        [InlineData("-48", "18", "6")] // 一个负数
        [InlineData("48", "-18", "6")] // 一个负数（交换顺序）
        [InlineData("-48", "-18", "6")]// 两个负数
        public void GreatestCommonDivisor_ShouldReturnExpectedResult_ForBigInteger(string number1, string number2, string expected)
        {
            var bigInt1 = BigInteger.Parse(number1);
            var bigInt2 = BigInteger.Parse(number2);
            var expectedBigInt = BigInteger.Parse(expected);

            Assert.Equal(expectedBigInt, bigInt1.GreatestCommonDivisor(bigInt2));
        }

        [Theory]
        [InlineData(4, 6, 12)]  // 正整数
        [InlineData(6, 4, 12)]  // 参数顺序交换
        [InlineData(0, 5, 0)]   // 一个参数为零
        [InlineData(5, 0, 0)]   // 一个参数为零（交换顺序）
        [InlineData(-4, 6, 12)] // 一个负数
        [InlineData(4, -6, 12)] // 一个负数（交换顺序）
        [InlineData(-4, -6, 12)]// 两个负数
        public void LeastCommonMultiple_TwoParameters_ShouldReturnExpectedResult_ForInt(int number1, int number2, int expected)
        {
            Assert.Equal(expected, number1.LeastCommonMultiple(number2));
        }

        [Theory]
        [InlineData(4L, 6L, 12L)]  // 正整数
        [InlineData(6L, 4L, 12L)]  // 参数顺序交换
        [InlineData(0L, 5L, 0L)]   // 一个参数为零
        [InlineData(5L, 0L, 0L)]   // 一个参数为零（交换顺序）
        [InlineData(-4L, 6L, 12L)] // 一个负数
        [InlineData(4L, -6L, 12L)] // 一个负数（交换顺序）
        [InlineData(-4L, -6L, 12L)]// 两个负数
        public void LeastCommonMultiple_TwoParameters_ShouldReturnExpectedResult_ForLong(long number1, long number2, long expected)
        {
            Assert.Equal(expected, number1.LeastCommonMultiple(number2));
        }

        [Theory]
        [InlineData("4", "6", "12")]  // 正整数
        [InlineData("6", "4", "12")]  // 参数顺序交换
        [InlineData("0", "5", "0")]   // 一个参数为零
        [InlineData("5", "0", "0")]   // 一个参数为零（交换顺序）
        [InlineData("-4", "6", "12")] // 一个负数
        [InlineData("4", "-6", "12")] // 一个负数（交换顺序）
        [InlineData("-4", "-6", "12")]// 两个负数
        public void LeastCommonMultiple_TwoParameters_ShouldReturnExpectedResult_ForBigInteger(string number1, string number2, string expected)
        {
            var bigInt1 = BigInteger.Parse(number1);
            var bigInt2 = BigInteger.Parse(number2);
            var expectedBigInt = BigInteger.Parse(expected);

            Assert.Equal(expectedBigInt, bigInt1.LeastCommonMultiple(bigInt2));
        }

        [Theory]
        [InlineData(new int[] { 4, 6, 8 }, 24)]  // 多个正整数
        [InlineData(new int[] { 6, 8, 4 }, 24)]  // 参数顺序交换
        [InlineData(new int[] { 0, 5, 10 }, 0)]  // 包含零
        [InlineData(new int[] { -4, 6, 8 }, 24)] // 包含负数
        [InlineData(new int[] { -4, -6, -8 }, 24)] // 全部负数
        public void LeastCommonMultiple_MultipleParameters_ShouldReturnExpectedResult_ForInt(int[] numbers, int expected)
        {
            Assert.Equal(expected, NumberExtensions.LeastCommonMultiple(numbers));
        }

        [Theory]
        [InlineData(new long[] { 4L, 6L, 8L }, 24L)]  // 多个正整数
        [InlineData(new long[] { 6L, 8L, 4L }, 24L)]  // 参数顺序交换
        [InlineData(new long[] { 0L, 5L, 10L }, 0L)]  // 包含零
        [InlineData(new long[] { -4L, 6L, 8L }, 24L)] // 包含负数
        [InlineData(new long[] { -4L, -6L, -8L }, 24L)] // 全部负数
        public void LeastCommonMultiple_MultipleParameters_ShouldReturnExpectedResult_ForLong(long[] numbers, long expected)
        {
            Assert.Equal(expected, NumberExtensions.LeastCommonMultiple(numbers));
        }

        [Theory]
        [InlineData(new string[] { "4", "6", "8" }, "24")]  // 多个正整数
        [InlineData(new string[] { "6", "8", "4" }, "24")]  // 参数顺序交换
        [InlineData(new string[] { "0", "5", "10" }, "0")]  // 包含零
        [InlineData(new string[] { "-4", "6", "8" }, "24")] // 包含负数
        [InlineData(new string[] { "-4", "-6", "-8" }, "24")] // 全部负数
        public void LeastCommonMultiple_MultipleParameters_ShouldReturnExpectedResult_ForBigInteger(string[] numbers, string expected)
        {
            var bigIntNumbers = numbers.Select(BigInteger.Parse).ToArray();
            var expectedBigInt = BigInteger.Parse(expected);

            Assert.Equal(expectedBigInt, NumberExtensions.LeastCommonMultiple(bigIntNumbers));
        }

        [Theory]
        [InlineData(0, 0)]    // 零
        [InlineData(1, 1)]    // 正整数
        [InlineData(-1, 1)]   // 负整数
        [InlineData(1.5, 1.5)] // 正小数
        [InlineData(-1.5, 1.5)] // 负小数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForDouble(double value, double expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(0, 0)]    // 零
        [InlineData(1, 1)]    // 正整数
        [InlineData(-1, 1)]   // 负整数
        [InlineData(1.5f, 1.5f)] // 正小数
        [InlineData(-1.5f, 1.5f)] // 负小数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForFloat(float value, float expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(0, 0)]    // 零
        [InlineData(1, 1)]    // 正整数
        [InlineData(-1, 1)]   // 负整数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForInt(int value, int expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData(0L, 0L)]    // 零
        [InlineData(1L, 1L)]    // 正整数
        [InlineData(-1L, 1L)]   // 负整数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForLong(long value, long expected)
        {
            Assert.Equal(expected, value.AbsoluteValue());
        }

        [Theory]
        [InlineData("0", "0")]    // 零
        [InlineData("1", "1")]    // 正整数
        [InlineData("-1", "1")]   // 负整数
        public void AbsoluteValue_ShouldReturnExpectedResult_ForBigInteger(string value, string expected)
        {
            var bigInteger = BigInteger.Parse(value);
            var expectedBigInteger = BigInteger.Parse(expected);

            Assert.Equal(expectedBigInteger, bigInteger.AbsoluteValue());
        }

        [Theory]
        [InlineData(5, 1, 10, true)]   // 在范围内
        [InlineData(1, 1, 10, true)]   // 等于最小值
        [InlineData(10, 1, 10, true)]  // 等于最大值
        [InlineData(0, 1, 10, false)]  // 小于最小值
        [InlineData(11, 1, 10, false)] // 大于最大值
        public void IsInRange_ShouldReturnExpectedResult_ForInt(int value, int min, int max, bool expected)
        {
            Assert.Equal(expected, value.IsInRange(min, max));
        }

        [Theory]
        [InlineData(5L, 1L, 10L, true)]   // 在范围内
        [InlineData(1L, 1L, 10L, true)]   // 等于最小值
        [InlineData(10L, 1L, 10L, true)]  // 等于最大值
        [InlineData(0L, 1L, 10L, false)]  // 小于最小值
        [InlineData(11L, 1L, 10L, false)] // 大于最大值
        public void IsInRange_ShouldReturnExpectedResult_ForLong(long value, long min, long max, bool expected)
        {
            Assert.Equal(expected, value.IsInRange(min, max));
        }

        [Theory]
        [InlineData(5.5, 1.1, 10.1, true)]   // 在范围内
        [InlineData(1.1, 1.1, 10.1, true)]   // 等于最小值
        [InlineData(10.1, 1.1, 10.1, true)]  // 等于最大值
        [InlineData(0.9, 1.1, 10.1, false)]  // 小于最小值
        [InlineData(10.2, 1.1, 10.1, false)] // 大于最大值
        public void IsInRange_ShouldReturnExpectedResult_ForDouble(double value, double min, double max, bool expected)
        {
            Assert.Equal(expected, value.IsInRange(min, max));
        }

        [Theory]
        [InlineData(5.5f, 1.1f, 10.1f, true)]   // 在范围内
        [InlineData(1.1f, 1.1f, 10.1f, true)]   // 等于最小值
        [InlineData(10.1f, 1.1f, 10.1f, true)]  // 等于最大值
        [InlineData(0.9f, 1.1f, 10.1f, false)]  // 小于最小值
        [InlineData(10.2f, 1.1f, 10.1f, false)] // 大于最大值
        public void IsInRange_ShouldReturnExpectedResult_ForFloat(float value, float min, float max, bool expected)
        {
            Assert.Equal(expected, value.IsInRange(min, max));
        }

        [Theory]
        [InlineData("5", "1", "10", true)]   // 在范围内
        [InlineData("1", "1", "10", true)]   // 等于最小值
        [InlineData("10", "1", "10", true)]  // 等于最大值
        [InlineData("0", "1", "10", false)]  // 小于最小值
        [InlineData("11", "1", "10", false)] // 大于最大值
        public void IsInRange_ShouldReturnExpectedResult_ForBigInteger(string value, string min, string max, bool expected)
        {
            var bigValue = BigInteger.Parse(value);
            var bigMin = BigInteger.Parse(min);
            var bigMax = BigInteger.Parse(max);

            Assert.Equal(expected, bigValue.IsInRange(bigMin, bigMax));
        }

        [Theory]
        [InlineData(123.456, 2, 123.46)]  // 正数，保留两位小数
        [InlineData(123.451, 2, 123.45)]  // 正数，四舍五入
        [InlineData(-123.456, 2, -123.46)] // 负数，保留两位小数
        [InlineData(-123.451, 2, -123.45)] // 负数，四舍五入
        [InlineData(0.0, 2, 0.0)]         // 零，保留两位小数
        [InlineData(123.456, 0, 123.0)]   // 正数，保留整数
        [InlineData(-123.456, 0, -123.0)] // 负数，保留整数
        [InlineData(123.456, 3, 123.456)] // 正数，保留三位小数
        [InlineData(-123.456, 3, -123.456)] // 负数，保留三位小数
        public void Keep_ShouldReturnExpectedResult_ForDouble(double value, int decimalPlaces, double expected)
        {
            Assert.Equal(expected, value.Keep(decimalPlaces));
        }

        [Theory]
        [InlineData(123.456f, 2, 123.46f)]  // 正数，保留两位小数
        [InlineData(123.451f, 2, 123.45f)]  // 正数，四舍五入
        [InlineData(-123.456f, 2, -123.46f)] // 负数，保留两位小数
        [InlineData(-123.451f, 2, -123.45f)] // 负数，四舍五入
        [InlineData(0.0f, 2, 0.0f)]         // 零，保留两位小数
        [InlineData(123.456f, 0, 123.0f)]   // 正数，保留整数
        [InlineData(-123.456f, 0, -123.0f)] // 负数，保留整数
        [InlineData(123.456f, 3, 123.456f)] // 正数，保留三位小数
        [InlineData(-123.456f, 3, -123.456f)] // 负数，保留三位小数
        public void Keep_ShouldReturnExpectedResult_ForFloat(float value, int decimalPlaces, float expected)
        {
            Assert.Equal(expected, value.Keep(decimalPlaces));
        }

        [Theory]
        [InlineData(0.1234, 2, "12.34%")]  // 正数，保留两位小数
        [InlineData(0.1234, 0, "12%")]     // 正数，保留整数
        [InlineData(-0.1234, 2, "-12.34%")] // 负数，保留两位小数
        [InlineData(-0.1234, 0, "-12%")]   // 负数，保留整数
        [InlineData(0.0, 2, "0.00%")]      // 零，保留两位小数
        [InlineData(1.0, 2, "100.00%")]    // 1 转换为百分比
        [InlineData(0.56789, 3, "56.789%")] // 保留三位小数
        public void ToPercentage_ShouldReturnExpectedResult_DefaultCulture(double value, int decimalPlaces, string expected)
        {
            Assert.Equal(expected, value.ToPercentage(decimalPlaces));
        }

        [Theory]
        [InlineData(0.1234, 2, "12,34%")]  // 正数，保留两位小数（德语文化）
        [InlineData(-0.1234, 2, "-12,34%")] // 负数，保留两位小数（德语文化）
        [InlineData(0.0, 2, "0,00%")]      // 零，保留两位小数（德语文化）
        [InlineData(1.0, 2, "100,00%")]    // 1 转换为百分比（德语文化）
        public void ToPercentage_ShouldReturnExpectedResult_SpecificCulture(double value, int decimalPlaces, string expected)
        {
            var germanCulture = new CultureInfo("de-DE");
            Assert.Equal(expected, value.ToPercentage(decimalPlaces, germanCulture));
        }

        [Theory]
        [InlineData(1234.56, "zh-CN", "¥1,234.56")]  // 正数，中文文化
        [InlineData(-1234.56, "zh-CN", "-¥1,234.56")] // 负数，中文文化
        [InlineData(0.0, "zh-CN", "¥0.00")]          // 零，中文文化
        [InlineData(1234.56, "en-US", "$1,234.56")]  // 正数，美国文化
        [InlineData(-1234.56, "en-US", "($1,234.56)")] // 负数，美国文化
        [InlineData(0.0, "en-US", "$0.00")]          // 零，美国文化
        [InlineData(1234.56, "de-DE", "1.234,56 €")] // 正数，德国文化
        [InlineData(-1234.56, "de-DE", "-1.234,56 €")] // 负数，德国文化
        [InlineData(0.0, "de-DE", "0,00 €")]         // 零，德国文化
        public void ToCurrency_ShouldReturnExpectedResult(double value, string cultureName, string expected)
        {
            var culture = new CultureInfo(cultureName);
            Assert.Equal(expected, value.ToCurrency(culture));
        }

        [Theory]
        [InlineData(1234.56, "¥1,234.56")]  // 正数，默认中文文化
        [InlineData(-1234.56, "-¥1,234.56")] // 负数，默认中文文化
        [InlineData(0.0, "¥0.00")]          // 零，默认中文文化
        public void ToCurrency_ShouldReturnExpectedResult_DefaultCulture(double value, string expected)
        {
            Assert.Equal(expected, value.ToCurrency());
        }

        [Theory]
        [InlineData(1234.5678, 2, "1.23E+03")]  // 正数，保留两位小数
        [InlineData(1234.5678, 3, "1.235E+03")] // 正数，保留三位小数
        [InlineData(-1234.5678, 2, "-1.23E+03")] // 负数，保留两位小数
        [InlineData(-1234.5678, 3, "-1.235E+03")] // 负数，保留三位小数
        [InlineData(0.0, 2, "0.00E+00")]        // 零，保留两位小数
        [InlineData(1.0, 2, "1.00E+00")]        // 1 转换为科学计数法
        [InlineData(0.0001234, 2, "1.23E-04")]  // 小数，保留两位小数
        public void ToScientificNotation_ShouldReturnExpectedResult_DefaultCulture(double value, int decimalPlaces, string expected)
        {
            Assert.Equal(expected, value.ToScientificNotation(decimalPlaces));
        }

        [Theory]
        [InlineData(1234.5678, 2, "1,23E+03")]  // 正数，保留两位小数（德语文化）
        [InlineData(-1234.5678, 2, "-1,23E+03")] // 负数，保留两位小数（德语文化）
        [InlineData(0.0, 2, "0,00E+00")]        // 零，保留两位小数（德语文化）
        [InlineData(1.0, 2, "1,00E+00")]        // 1 转换为科学计数法（德语文化）
        [InlineData(0.0001234, 2, "1,23E-04")]  // 小数，保留两位小数（德语文化）
        public void ToScientificNotation_ShouldReturnExpectedResult_SpecificCulture(double value, int decimalPlaces, string expected)
        {
            var germanCulture = new CultureInfo("de-DE");
            Assert.Equal(expected, value.ToScientificNotation(decimalPlaces, germanCulture));
        }

        [Theory]
        [InlineData(0.0, "零元")]                      // 零
        [InlineData(123.45, "壹佰贰拾叁元肆角伍分")]    // 正数（小数）
        [InlineData(-123.45, "负壹佰贰拾叁元肆角伍分")] // 负数（小数）
        [InlineData(123.00, "壹佰贰拾叁元整")]          // 正数（整数）
        [InlineData(-123.00, "负壹佰贰拾叁元整")]       // 负数（整数）
        [InlineData(1000.01, "壹仟元零壹分")]          // 边界值（千位）
        [InlineData(-1000.01, "负壹仟元零壹分")]       // 边界值（负千位）
        [InlineData(1000000.00, "壹佰万元整")]          // 边界值（百万）
        [InlineData(-1000000.00, "负壹佰万元整")]       // 边界值（负百万）
        public void ChineseCapitalized_ShouldReturnExpectedResult_ForDouble(double value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }

        [Theory]
        [InlineData(0.0f, "零元")]                      // 零
        [InlineData(123.45f, "壹佰贰拾叁元肆角伍分")]    // 正数（小数）
        [InlineData(-123.45f, "负壹佰贰拾叁元肆角伍分")] // 负数（小数）
        [InlineData(123.00f, "壹佰贰拾叁元整")]          // 正数（整数）
        [InlineData(-123.00f, "负壹佰贰拾叁元整")]       // 负数（整数）
        [InlineData(1000.01f, "壹仟元零壹分")]          // 边界值（千位）
        [InlineData(-1000.01f, "负壹仟元零壹分")]       // 边界值（负千位）
        [InlineData(1000000.00f, "壹佰万元整")]          // 边界值（百万）
        [InlineData(-1000000.00f, "负壹佰万元整")]       // 边界值（负百万）
        public void ChineseCapitalized_ShouldReturnExpectedResult_ForFloat(float value, string expected)
        {
            Assert.Equal(expected, value.ChineseCapitalized());
        }
    }
}
