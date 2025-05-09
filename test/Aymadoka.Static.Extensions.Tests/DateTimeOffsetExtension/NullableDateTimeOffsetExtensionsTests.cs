using Aymadoka.Static.NullableDateTimeExtension;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class NullableDateTimeOffsetExtensionsTests
    {
        [Theory] 
        [InlineData(2025, 12, 31, 23, 59, 59, 0, "yyyy-MM-dd", "2025-12-31")] // 自定义格式
        [InlineData(2025, 12, 31, 23, 59, 59, 0, "MM/dd/yyyy", "12/31/2025")] // 不同格式
        [InlineData(2025, 12, 31, 23, 59, 59, 0, null, "2025/12/31 23:59:59")] // 默认格式
        public void ToString_ShouldReturnFormattedString_WhenDateTimeIsNotNull(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            string? format, string expected)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.ToString(format);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToString_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.ToString("yyyy-MM-dd");

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 12, 31, 23, 59, 59, 0, 2025, 12, 31)] // 普通日期
        [InlineData(2024, 2, 29, 12, 0, 0, 0, 2024, 2, 29)] // 闰年日期
        [InlineData(2025, 1, 1, 0, 0, 0, 0, 2025, 1, 1)] // 边界值：午夜
        public void RemoveTime_ShouldReturnDateOnly_WhenDateTimeIsNotNull(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void RemoveTime_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 2025, 4, 14)] // 普通日期
        [InlineData(2025, 3, 1, 0, 0, 0, 2025, 2, 28)] // 月初（非闰年）
        [InlineData(2024, 3, 1, 0, 0, 0, 2024, 2, 29)] // 月初（闰年）
        [InlineData(2025, 1, 1, 0, 0, 0, 2024, 12, 31)] // 年初
        public void PreviousDay_ShouldReturnPreviousDay_WhenDateTimeIsNotNull(
            int year, int month, int day, int hour, int minute, int second,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.Yesterday();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay, hour, minute, second), result);
        }

        [Fact]
        public void PreviousDay_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.Yesterday();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 2025, 4, 16)] // 普通日期
        [InlineData(2025, 2, 28, 0, 0, 0, 2025, 3, 1)] // 月末（非闰年）
        [InlineData(2024, 2, 28, 0, 0, 0, 2024, 2, 29)] // 月末（闰年）
        [InlineData(2025, 12, 31, 0, 0, 0, 2026, 1, 1)] // 年末
        public void NextDay_ShouldReturnNextDay_WhenDateTimeIsNotNull(
            int year, int month, int day, int hour, int minute, int second,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.Tomorrow();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay, hour, minute, second), result);
        }

        [Fact]
        public void NextDay_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.Tomorrow();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 1)] // 普通日期
        [InlineData(2025, 12, 31, 2025, 12, 1)] // 年末
        [InlineData(2024, 2, 29, 2024, 2, 1)] // 闰年
        public void CurrentMonthFirstDay_ShouldReturnFirstDayOfMonth_WhenDateTimeIsNotNull(
    int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.CurrentMonthFirstDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void CurrentMonthFirstDay_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.CurrentMonthFirstDay();

            // Assert
            Assert.Null(result);
        }

    }
}
