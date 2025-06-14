using Xunit;
using System;

namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetMonthSecondDayTests
    {
        [Fact]
        public void GetMonthSecondDay_January_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTimeOffset(2024, 1, 15, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(2024, 1, 2, 0, 0, 0, TimeSpan.Zero);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMonthSecondDay_FebruaryLeapYear_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTimeOffset(2024, 2, 29, 0, 0, 0, TimeSpan.Zero); // 2024 is leap year
            var expected = new DateTimeOffset(2024, 2, 2, 0, 0, 0, TimeSpan.Zero);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMonthSecondDay_FebruaryNonLeapYear_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTimeOffset(2023, 2, 1, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(2023, 2, 2, 0, 0, 0, TimeSpan.Zero);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMonthSecondDay_December_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTimeOffset(2023, 12, 31, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(2023, 12, 2, 0, 0, 0, TimeSpan.Zero);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}