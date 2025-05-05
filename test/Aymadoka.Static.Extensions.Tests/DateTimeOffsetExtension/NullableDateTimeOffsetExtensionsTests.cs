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

        [Theory]
        [InlineData(2025, 4, 15, 2025, 3, 1)] // 普通日期
        [InlineData(2025, 1, 15, 2024, 12, 1)] // 年初
        [InlineData(2024, 3, 15, 2024, 2, 1)] // 闰年
        public void GetFirstDayOfLastMonth_ShouldReturnFirstDayOfPreviousMonth_WhenDateTimeIsNotNull(
            int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetFirstDayOfLastMonth();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetFirstDayOfLastMonth_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.GetFirstDayOfLastMonth();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 5, 1)] // 普通日期
        [InlineData(2025, 12, 15, 2026, 1, 1)] // 年末
        [InlineData(2024, 2, 15, 2024, 3, 1)] // 闰年
        public void GetFirstDayOfNextMonth_ShouldReturnFirstDayOfNextMonth_WhenDateTimeIsNotNull(
            int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetFirstDayOfNextMonth();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetFirstDayOfNextMonth_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.GetFirstDayOfNextMonth();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 1)] // 普通日期
        [InlineData(2025, 12, 31, 2025, 12, 1)] // 年末
        [InlineData(2024, 2, 29, 2024, 2, 1)] // 闰年
        public void GetFirstDayOfMonth_ShouldReturnFirstDayOfMonth_WhenDateTimeIsNotNull(
     int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetFirstDayOfMonth();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetFirstDayOfMonth_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.GetFirstDayOfMonth();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 30)] // 普通日期
        [InlineData(2025, 12, 31, 2025, 12, 31)] // 年末
        [InlineData(2024, 2, 29, 2024, 2, 29)] // 闰年
        public void GetLastDayOfMonth_ShouldReturnLastDayOfMonth_WhenDateTimeIsNotNull(
            int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetLastDayOfMonth();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetLastDayOfMonth_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.GetLastDayOfMonth();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 29)] // 普通日期
        [InlineData(2025, 12, 31, 2025, 12, 30)] // 年末
        [InlineData(2024, 2, 29, 2024, 2, 28)] // 闰年
        public void GetSecondDayToLastOfMonth_ShouldReturnSecondToLastDayOfMonth_WhenDateTimeIsNotNull(
            int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetSecondDayToLastOfMonth();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetSecondDayToLastOfMonth_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.GetSecondDayToLastOfMonth();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 30)] // 普通日期
        [InlineData(2025, 12, 31, 2025, 12, 31)] // 年末
        [InlineData(2024, 2, 29, 2024, 2, 29)] // 闰年
        public void CurrentMonthLastDay_ShouldReturnLastDayOfMonth_WhenDateTimeIsNotNull(
    int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.CurrentMonthLastDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void CurrentMonthLastDay_ShouldReturnNull_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.CurrentMonthLastDay();

            // Assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2025, 4, 25, false)] // 周五
        [InlineData(2025, 4, 26, true)]  // 周六
        [InlineData(2025, 4, 27, true)]  // 周日
        [InlineData(2025, 4, 28, false)] // 周一
        public void IsWeekend_ShouldReturnCorrectResult_WhenDateTimeIsNotNull(
            int year, int month, int day, bool expectedResult)
        {
            // Arrange
            DateTime? dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.IsWeekend();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IsWeekend_ShouldReturnFalse_WhenDateTimeIsNull()
        {
            // Arrange
            DateTime? dateTime = null;

            // Act
            var result = dateTime.IsWeekend();

            // Assert
            Assert.False(result);
        }
    }
}
