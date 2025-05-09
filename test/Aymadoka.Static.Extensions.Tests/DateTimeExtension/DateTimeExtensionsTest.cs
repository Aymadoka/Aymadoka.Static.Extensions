using Aymadoka.Static.DateTimeExtension;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class DateTimeExtensionsTest
    {
        [Theory] 
        [InlineData(2025, 4, 26, 15, 30, 45, 2025, 4, 26)] // 常规日期和时间
        [InlineData(1970, 1, 1, 0, 0, 0, 1970, 1, 1)] // Unix 纪元时间
        [InlineData(2024, 2, 29, 23, 59, 59, 2024, 2, 29)] // 闰年 2 月 29 日
        [InlineData(2025, 12, 31, 23, 59, 59, 2025, 12, 31)] // 跨年边界的最后一秒
        [InlineData(2026, 1, 1, 0, 0, 0, 2026, 1, 1)] // 跨年边界的第一秒
        public void RemoveTime_ShouldReturnDateOnly(
            int year, int month, int day, int hour, int minute, int second,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
            Assert.Equal(0, result.Hour);
            Assert.Equal(0, result.Minute);
            Assert.Equal(0, result.Second);
        }

        [Fact]
        public void RemoveTime_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.RemoveTime();
            var localResult = localDateTime.RemoveTime();
            var unspecifiedResult = unspecifiedDateTime.RemoveTime();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 26, 15, 30, 45, 2025, 4, 25, 15, 30, 45)] // 常规日期
        [InlineData(2024, 3, 1, 0, 0, 0, 2024, 2, 29, 0, 0, 0)] // 闰年 2 月 29 日
        [InlineData(2025, 1, 1, 0, 0, 0, 2024, 12, 31, 0, 0, 0)] // 跨年
        [InlineData(1970, 1, 2, 0, 0, 0, 1970, 1, 1, 0, 0, 0)] // Unix 纪元
        public void PreviousDay_ShouldReturnCorrectDate(
            int year, int month, int day, int hour, int minute, int second,
            int expectedYear, int expectedMonth, int expectedDay, int expectedHour, int expectedMinute, int expectedSecond)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.Yesterday();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay, expectedHour, expectedMinute, expectedSecond), result);
        }

        [Fact]
        public void PreviousDay_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.Yesterday();
            var localResult = localDateTime.Yesterday();
            var unspecifiedResult = unspecifiedDateTime.Yesterday();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 26, 15, 30, 45, 2025, 4, 27, 15, 30, 45)] // 常规日期
        [InlineData(2024, 2, 28, 0, 0, 0, 2024, 2, 29, 0, 0, 0)] // 闰年 2 月 28 日
        [InlineData(2024, 2, 29, 0, 0, 0, 2024, 3, 1, 0, 0, 0)] // 闰年 2 月 29 日
        [InlineData(2025, 12, 31, 23, 59, 59, 2026, 1, 1, 23, 59, 59)] // 跨年
        [InlineData(1970, 1, 1, 0, 0, 0, 1970, 1, 2, 0, 0, 0)] // Unix 纪元
        public void NextDay_ShouldReturnCorrectDate(
            int year, int month, int day, int hour, int minute, int second,
            int expectedYear, int expectedMonth, int expectedDay, int expectedHour, int expectedMinute, int expectedSecond)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.Tomorrow();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay, expectedHour, expectedMinute, expectedSecond), result);
        }

        [Fact]
        public void NextDay_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.Tomorrow();
            var localResult = localDateTime.Tomorrow();
            var unspecifiedResult = unspecifiedDateTime.Tomorrow();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 26, 15, 30, 45, "2025-04-01")] // 常规日期
        [InlineData(2024, 2, 29, 0, 0, 0, "2024-02-01")] // 闰年 2 月 29 日
        [InlineData(2025, 1, 1, 0, 0, 0, "2025-01-01")] // 年初
        [InlineData(2025, 12, 31, 23, 59, 59, "2025-12-01")] // 年末
        [InlineData(1970, 1, 15, 0, 0, 0, "1970-01-01")] // Unix 纪元
        public void CurrentMonthFirstDay_ShouldReturnFirstDayOfMonth(
            int year, int month, int day, int hour, int minute, int second,
            string expectedStr)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day, hour, minute, second);

            // Act
            var result = dateTime.CurrentMonthFirstDay();
            var expected = DateTime.Parse(expectedStr);



            // Assert
            Assert.Equal(expected.Year, result.Year);
            Assert.Equal(expected.Month, result.Month);
            Assert.Equal(expected.Day, result.Day);
        }

        [Fact]
        public void CurrentMonthFirstDay_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.CurrentMonthFirstDay();
            var localResult = localDateTime.CurrentMonthFirstDay();
            var unspecifiedResult = unspecifiedDateTime.CurrentMonthFirstDay();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 26, 2025, 3, 1)] // 常规日期
        [InlineData(2025, 1, 15, 2024, 12, 1)] // 跨年（从 1 月到上一年的 12 月）
        [InlineData(2024, 3, 15, 2024, 2, 1)] // 闰年 2 月
        [InlineData(2024, 2, 29, 2024, 1, 1)] // 闰年 2 月 29 日
        [InlineData(1970, 1, 15, 1969, 12, 1)] // Unix 纪元前的日期
        public void GetFirstDayOfLastMonth_ShouldReturnCorrectDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetLastMonthFirstDay();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetFirstDayOfLastMonth_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.GetLastMonthFirstDay();
            var localResult = localDateTime.GetLastMonthFirstDay();
            var unspecifiedResult = unspecifiedDateTime.GetLastMonthFirstDay();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 26, 2025, 5, 1)] // 常规日期
        [InlineData(2025, 12, 15, 2026, 1, 1)] // 跨年（从 12 月到下一年的 1 月）
        [InlineData(2024, 1, 31, 2024, 2, 1)] // 闰年 1 月到 2 月
        [InlineData(2024, 2, 29, 2024, 3, 1)] // 闰年 2 月 29 日
        [InlineData(1970, 1, 15, 1970, 2, 1)] // Unix 纪元后的日期
        public void GetFirstDayOfNextMonth_ShouldReturnCorrectDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetNextMonthFirstDay();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetFirstDayOfNextMonth_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.GetNextMonthFirstDay();
            var localResult = localDateTime.GetNextMonthFirstDay();
            var unspecifiedResult = unspecifiedDateTime.GetNextMonthFirstDay();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 26, 2025, 4, 1)] // 常规日期
        [InlineData(2024, 2, 29, 2024, 2, 1)] // 闰年 2 月 29 日
        [InlineData(2025, 1, 15, 2025, 1, 1)] // 年初
        [InlineData(2025, 12, 31, 2025, 12, 1)] // 年末
        [InlineData(1970, 1, 15, 1970, 1, 1)] // Unix 纪元后的日期
        public void GetFirstDayOfMonth_ShouldReturnCorrectDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.CurrentMonthFirstDay();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetFirstDayOfMonth_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 26, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.CurrentMonthFirstDay();
            var localResult = localDateTime.CurrentMonthFirstDay();
            var unspecifiedResult = unspecifiedDateTime.CurrentMonthFirstDay();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 30)] // 常规日期
        [InlineData(2024, 2, 15, 2024, 2, 29)] // 闰年 2 月
        [InlineData(2025, 2, 15, 2025, 2, 28)] // 非闰年 2 月
        [InlineData(2025, 1, 1, 2025, 1, 31)] // 年初
        [InlineData(2025, 12, 15, 2025, 12, 31)] // 年末
        [InlineData(1970, 1, 15, 1970, 1, 31)] // Unix 纪元后的日期
        public void GetLastDayOfMonth_ShouldReturnCorrectDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetLastDayOfMonth_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.GetCurrentMonthLastDay();
            var localResult = localDateTime.GetCurrentMonthLastDay();
            var unspecifiedResult = unspecifiedDateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 29)] // 常规日期
        [InlineData(2024, 2, 15, 2024, 2, 28)] // 闰年 2 月
        [InlineData(2025, 2, 15, 2025, 2, 27)] // 非闰年 2 月
        [InlineData(2025, 1, 1, 2025, 1, 30)] // 年初
        [InlineData(2025, 12, 15, 2025, 12, 30)] // 年末
        [InlineData(1970, 1, 15, 1970, 1, 30)] // Unix 纪元后的日期
        public void GetSecondDayToLastOfMonth_ShouldReturnCorrectDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetLastOfMonthSecondDay();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void GetSecondDayToLastOfMonth_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.GetLastOfMonthSecondDay();
            var localResult = localDateTime.GetLastOfMonthSecondDay();
            var unspecifiedResult = unspecifiedDateTime.GetLastOfMonthSecondDay();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 15, 2025, 4, 30)] // 常规日期
        [InlineData(2024, 2, 15, 2024, 2, 29)] // 闰年 2 月
        [InlineData(2025, 2, 15, 2025, 2, 28)] // 非闰年 2 月
        [InlineData(2025, 1, 1, 2025, 1, 31)] // 年初
        [InlineData(2025, 12, 15, 2025, 12, 31)] // 年末
        [InlineData(1970, 1, 15, 1970, 1, 31)] // Unix 纪元后的日期
        public void CurrentMonthLastDay_ShouldReturnCorrectDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var result = dateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result);
        }

        [Fact]
        public void CurrentMonthLastDay_ShouldPreserveDateKind()
        {
            // Arrange
            var utcDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Utc);
            var localDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Local);
            var unspecifiedDateTime = new DateTime(2025, 4, 15, 15, 30, 45, DateTimeKind.Unspecified);

            // Act
            var utcResult = utcDateTime.GetCurrentMonthLastDay();
            var localResult = localDateTime.GetCurrentMonthLastDay();
            var unspecifiedResult = unspecifiedDateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.Equal(DateTimeKind.Utc, utcResult.Kind);
            Assert.Equal(DateTimeKind.Local, localResult.Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedResult.Kind);
        }

        [Theory]
        [InlineData(2025, 4, 26, true)] // 星期六
        [InlineData(2025, 4, 27, true)] // 星期日
        [InlineData(2025, 4, 28, false)] // 星期一
        [InlineData(2025, 4, 29, false)] // 星期二
        [InlineData(2025, 4, 30, false)] // 星期三
        [InlineData(2025, 5, 1, false)] // 星期四
        [InlineData(2025, 5, 2, false)] // 星期五
        public void IsWeekend_ShouldReturnCorrectResultForAllDaysOfWeek(int year, int month, int day, bool expected)
        {
            // Arrange
            var date = new DateTime(year, month, day);

            // Act
            var result = date.IsWeekendDay();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2022, 12, 31, true)] // 跨年边界的星期六
        [InlineData(2023, 1, 1, true)] // 跨年边界的星期日
        [InlineData(2024, 2, 24, true)] // 闰年的星期六
        [InlineData(2024, 2, 25, true)] // 闰年的星期日
        [InlineData(2024, 2, 26, false)] // 闰年的星期一
        public void IsWeekend_ShouldHandleSpecialDatesCorrectly(int year, int month, int day, bool expected)
        {
            // Arrange
            var date = new DateTime(year, month, day);

            // Act
            var result = date.IsWeekendDay();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
