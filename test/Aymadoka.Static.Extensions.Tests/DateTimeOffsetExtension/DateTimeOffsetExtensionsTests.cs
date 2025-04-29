using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffsetExtensionsTests
    {
        [Theory]
        [InlineData(2025, 4, 27, 15, 30, 45, 0, 2025, 4, 27)] // 普通日期
        [InlineData(2025, 12, 31, 23, 59, 59, 4, 2025, 12, 31)] // 年末
        [InlineData(2024, 2, 29, 12, 0, 0, 8, 2024, 2, 29)] // 闰年
        public void RemoveTime_ShouldRemoveTimePart(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromHours(offsetMinutes));

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromHours(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 27, 0, 0, 0, 0, 2025, 4, 26)] // 普通日期
        [InlineData(2025, 3, 1, 0, 0, 0, 0, 2025, 2, 28)] // 月初
        [InlineData(2024, 3, 1, 0, 0, 0, 0, 2024, 2, 29)] // 闰年
        public void PreviousDay_ShouldReturnPreviousDay(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.PreviousDay();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 27, 0, 0, 0, 0, 2025, 4, 28)] // 普通日期
        [InlineData(2025, 12, 31, 0, 0, 0, 0, 2026, 1, 1)] // 年末
        [InlineData(2024, 2, 28, 0, 0, 0, 0, 2024, 2, 29)] // 闰年
        public void NextDay_ShouldReturnNextDay(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.NextDay();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 0, 2025, 4, 1)] // 普通日期
        [InlineData(2025, 12, 31, 0, 0, 0, 0, 2025, 12, 1)] // 年末
        [InlineData(2024, 2, 29, 0, 0, 0, 0, 2024, 2, 1)] // 闰年
        public void CurrentMonthFirstDay_ShouldReturnFirstDayOfMonth(
    int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
    int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.CurrentMonthFirstDay();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 0, 2025, 3, 1)] // 普通日期
        [InlineData(2025, 1, 15, 0, 0, 0, 0, 2024, 12, 1)] // 年初
        [InlineData(2024, 3, 15, 0, 0, 0, 0, 2024, 2, 1)] // 闰年
        public void GetFirstDayOfLastMonth_ShouldReturnFirstDayOfPreviousMonth(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.GetFirstDayOfLastMonth();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 0, 2025, 5, 1)] // 普通日期
        [InlineData(2025, 12, 15, 0, 0, 0, 0, 2026, 1, 1)] // 年末
        [InlineData(2024, 2, 15, 0, 0, 0, 0, 2024, 3, 1)] // 闰年
        public void GetFirstDayOfNextMonth_ShouldReturnFirstDayOfNextMonth(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.GetFirstDayOfNextMonth();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 0, 2025, 4, 1)] // 普通日期
        [InlineData(2025, 12, 31, 0, 0, 0, 0, 2025, 12, 1)] // 年末
        [InlineData(2024, 2, 29, 0, 0, 0, 0, 2024, 2, 1)] // 闰年
        public void GetFirstDayOfMonth_ShouldReturnFirstDayOfMonth(
    int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
    int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.GetFirstDayOfMonth();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 0, 2025, 4, 30)] // 普通日期
        [InlineData(2025, 12, 31, 0, 0, 0, 0, 2025, 12, 31)] // 年末
        [InlineData(2024, 2, 29, 0, 0, 0, 0, 2024, 2, 29)] // 闰年
        public void GetLastDayOfMonth_ShouldReturnLastDayOfMonth(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.GetLastDayOfMonth();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 0, 2025, 4, 29)] // 普通日期
        [InlineData(2025, 12, 31, 0, 0, 0, 0, 2025, 12, 30)] // 年末
        [InlineData(2024, 2, 29, 0, 0, 0, 0, 2024, 2, 28)] // 闰年
        public void GetSecondDayToLastOfMonth_ShouldReturnSecondToLastDayOfMonth(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.GetSecondDayToLastOfMonth();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 15, 0, 0, 0, 0, 2025, 4, 30)] // 普通日期
        [InlineData(2025, 12, 31, 0, 0, 0, 0, 2025, 12, 31)] // 年末
        [InlineData(2024, 2, 29, 0, 0, 0, 0, 2024, 2, 29)] // 闰年
        public void CurrentMonthLastDay_ShouldReturnLastDayOfMonth(
    int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
    int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.CurrentMonthLastDay();

            // Assert
            Assert.Equal(new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.FromMinutes(offsetMinutes)), result);
        }

        [Theory]
        [InlineData(2025, 4, 25, 0, 0, 0, 0, false)] // 周五
        [InlineData(2025, 4, 26, 0, 0, 0, 0, true)] // 周六
        [InlineData(2025, 4, 27, 0, 0, 0, 0, true)] // 周日
        [InlineData(2025, 4, 2, 0, 0, 0, 0, false)] // 普通工作日
        public void IsWeekend_ShouldReturnCorrectResult(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            bool expectedResult)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.IsWeekend();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2025, 4, 27, 0, 0, 0, 8, 1745683200)] // 普通日期
        [InlineData(1970, 1, 1, 0, 0, 0, 8, -28800)] // Unix 时间戳起点
        [InlineData(1970, 1, 1, 8, 0, 0, 8, 0)] // Unix 时间戳起点
        [InlineData(2000, 1, 1, 8, 0, 0, 8, 946684800)] // 2000 年 1 月 1 日
        public void GetSecondLevelTimeStamp_ShouldReturnCorrectTimestamp(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            long expectedTimestamp)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromHours(offsetMinutes));

            // Act
            var result = dateTime.GetSecondLevelTimeStamp();

            // Assert
            Assert.Equal(expectedTimestamp, result);
        }

        [Theory]
        [InlineData(2025, 4, 27, 0, 0, 0, 0, 1745712000000)] // 普通日期
        [InlineData(1970, 1, 1, 0, 0, 0, 0, 0)] // Unix 时间戳起点
        [InlineData(2000, 1, 1, 0, 0, 0, 0, 946684800000)] // 2000 年 1 月 1 日
        public void GetMillisecondLevelTimeStamp_ShouldReturnCorrectTimestamp(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            long expectedTimestamp)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));

            // Act
            var result = dateTime.GetMillisecondLevelTimeStamp();

            // Assert
            Assert.Equal(expectedTimestamp, result);
        }

        [Theory]
        [InlineData(2025, 4, 27, 0, 0, 0, 0, 2025, 4, 26, 0, 0, 0, 0, 2025, 4, 28, 0, 0, 0, 0, true)] // 在范围内
        [InlineData(2025, 4, 27, 0, 0, 0, 0, 2025, 4, 27, 0, 0, 0, 0, 2025, 4, 27, 23, 59, 59, 0, true)] // 边界值
        [InlineData(2025, 4, 27, 0, 0, 0, 0, 2025, 4, 28, 0, 0, 0, 0, 2025, 4, 29, 0, 0, 0, 0, false)] // 超出范围
        [InlineData(2025, 4, 27, 0, 0, 0, 0, 2025, 4, 25, 0, 0, 0, 0, 2025, 4, 26, 23, 59, 59, 0, false)] // 在范围外
        public void IsBetween_ShouldReturnCorrectResult(
            int year, int month, int day, int hour, int minute, int second, int offsetMinutes,
            int startYear, int startMonth, int startDay, int startHour, int startMinute, int startSecond, int startOffsetMinutes,
            int endYear, int endMonth, int endDay, int endHour, int endMinute, int endSecond, int endOffsetMinutes,
            bool expectedResult)
        {
            // Arrange
            var dateTime = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.FromMinutes(offsetMinutes));
            var start = new DateTimeOffset(startYear, startMonth, startDay, startHour, startMinute, startSecond, TimeSpan.FromMinutes(startOffsetMinutes));
            var end = new DateTimeOffset(endYear, endMonth, endDay, endHour, endMinute, endSecond, TimeSpan.FromMinutes(endOffsetMinutes));

            // Act
            var result = dateTime.IsBetween(start, end);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
