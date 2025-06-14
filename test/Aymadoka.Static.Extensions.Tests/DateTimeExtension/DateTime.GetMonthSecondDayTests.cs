using Xunit;
using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetMonthSecondDayTests
    {
        [Fact]
        public void GetMonthSecondDay_January_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTime(2024, 1, 15);
            var expected = new DateTime(2024, 1, 2);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMonthSecondDay_FebruaryLeapYear_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTime(2024, 2, 29); // 2024 is leap year
            var expected = new DateTime(2024, 2, 2);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMonthSecondDay_FebruaryNonLeapYear_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTime(2023, 2, 1);
            var expected = new DateTime(2023, 2, 2);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMonthSecondDay_December_ReturnsSecondDay()
        {
            // Arrange
            var date = new DateTime(2023, 12, 31);
            var expected = new DateTime(2023, 12, 2);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}