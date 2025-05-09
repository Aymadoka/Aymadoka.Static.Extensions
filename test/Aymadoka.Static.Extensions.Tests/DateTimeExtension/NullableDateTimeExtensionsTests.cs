using Shouldly;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTimeExtensionsTests
    {
        [Fact] 
        public void ToString_ShouldReturnDefaultFormattedString_WhenFormatIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 26);

            // Act
            var result = sourceDateTime.ToString(null);

            // Assert
            Assert.Equal(sourceDateTime.Value.ToString(), result);
        }

        [Fact]
        public void ToString_ShouldReturnFormattedString_WhenFormatIsProvided()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 26);
            string format = "yyyy-MM-dd";

            // Act
            var result = sourceDateTime.ToString(format);

            // Assert
            Assert.Equal("2025-04-26", result);
        }

        [Fact]
        public void ToString_ShouldHandleVariousFormatsAndNullSourceDateTime()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? validDateTime = new DateTime(2025, 4, 26);
            string? nullFormat = null;
            string customFormat = "MM/dd/yyyy";

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.ToString(nullFormat));
            Assert.Null(nullDateTime.ToString(customFormat));

            // Valid DateTime with null format
            Assert.Equal(validDateTime.Value.ToString(), validDateTime.ToString(nullFormat));

            // Valid DateTime with custom format
            Assert.Equal("04/26/2025", validDateTime.ToString(customFormat));
        }

        [Fact]
        public void RemoveTime_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.RemoveTime();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void RemoveTime_ShouldReturnDateWithoutTime_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 26, 15, 30, 45); // Date with time

            // Act
            var result = sourceDateTime.RemoveTime();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 26), result); // Only date part should remain
        }

        [Fact]
        public void RemoveTime_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? dateWithTime = new DateTime(2025, 4, 26, 23, 59, 59);
            DateTime? midnightDate = new DateTime(2025, 4, 26, 0, 0, 0);

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.RemoveTime());

            // DateTime with time
            var resultWithTime = dateWithTime.RemoveTime();
            Assert.NotNull(resultWithTime);
            Assert.Equal(new DateTime(2025, 4, 26), resultWithTime);

            // DateTime already at midnight
            var resultMidnight = midnightDate.RemoveTime();
            Assert.NotNull(resultMidnight);
            Assert.Equal(midnightDate, resultMidnight); // Should remain unchanged
        }

        [Fact]
        public void PreviousDay_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.Yesterday();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void PreviousDay_ShouldReturnPreviousDay_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 26);

            // Act
            var result = sourceDateTime.Yesterday();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 25), result);
        }

        [Fact]
        public void PreviousDay_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? normalDate = new DateTime(2025, 4, 26);
            DateTime? firstDayOfMonth = new DateTime(2025, 4, 1);
            DateTime? leapYearDate = new DateTime(2024, 3, 1); // Leap year scenario

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.Yesterday());

            // Normal Date
            var resultNormalDate = normalDate.Yesterday();
            Assert.NotNull(resultNormalDate);
            Assert.Equal(new DateTime(2025, 4, 25), resultNormalDate);

            // First Day of Month
            var resultFirstDayOfMonth = firstDayOfMonth.Yesterday();
            Assert.NotNull(resultFirstDayOfMonth);
            Assert.Equal(new DateTime(2025, 3, 31), resultFirstDayOfMonth);

            // Leap Year Date
            var resultLeapYearDate = leapYearDate.Yesterday();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 29), resultLeapYearDate); // Leap year February 29
        }

        [Fact]
        public void NextDay_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.Tomorrow();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void NextDay_ShouldReturnNextDay_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 26);

            // Act
            var result = sourceDateTime.Tomorrow();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 27), result);
        }

        [Fact]
        public void NextDay_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? normalDate = new DateTime(2025, 4, 26);
            DateTime? lastDayOfMonth = new DateTime(2025, 4, 30);
            DateTime? leapYearDate = new DateTime(2024, 2, 28); // Leap year scenario

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.Tomorrow());

            // Normal Date
            var resultNormalDate = normalDate.Tomorrow();
            Assert.NotNull(resultNormalDate);
            Assert.Equal(new DateTime(2025, 4, 27), resultNormalDate);

            // Last Day of Month
            var resultLastDayOfMonth = lastDayOfMonth.Tomorrow();
            Assert.NotNull(resultLastDayOfMonth);
            Assert.Equal(new DateTime(2025, 5, 1), resultLastDayOfMonth);

            // Leap Year Date
            var resultLeapYearDate = leapYearDate.Tomorrow();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 29), resultLeapYearDate); // Leap year February 29
        }

        [Fact]
        public void CurrentMonthFirstDay_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.CurrentMonthFirstDay();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void CurrentMonthFirstDay_ShouldReturnFirstDayOfMonth_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 26);

            // Act
            var result = sourceDateTime.CurrentMonthFirstDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 1), result);
        }

        [Fact]
        public void CurrentMonthFirstDay_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? midMonthDate = new DateTime(2025, 4, 15);
            DateTime? firstDayOfMonth = new DateTime(2025, 4, 1);
            DateTime? leapYearDate = new DateTime(2024, 2, 29); // Leap year scenario

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.CurrentMonthFirstDay());

            // Mid-month Date
            var resultMidMonth = midMonthDate.CurrentMonthFirstDay();
            Assert.NotNull(resultMidMonth);
            Assert.Equal(new DateTime(2025, 4, 1), resultMidMonth);

            // First Day of Month
            var resultFirstDayOfMonth = firstDayOfMonth.CurrentMonthFirstDay();
            Assert.NotNull(resultFirstDayOfMonth);
            Assert.Equal(new DateTime(2025, 4, 1), resultFirstDayOfMonth);

            // Leap Year Date
            var resultLeapYearDate = leapYearDate.CurrentMonthFirstDay();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 1), resultLeapYearDate);
        }

        [Fact]
        public void GetFirstDayOfLastMonth_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.GetLastMonthFirstDay();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetFirstDayOfLastMonth_ShouldReturnFirstDayOfPreviousMonth_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 15);

            // Act
            var result = sourceDateTime.GetLastMonthFirstDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 3, 1), result);
        }

        [Fact]
        public void GetFirstDayOfLastMonth_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? midMonthDate = new DateTime(2025, 4, 15);
            DateTime? firstDayOfMonth = new DateTime(2025, 4, 1);
            DateTime? januaryDate = new DateTime(2025, 1, 15); // Crossing year boundary
            DateTime? leapYearDate = new DateTime(2024, 3, 15); // Leap year scenario

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.GetLastMonthFirstDay());

            // Mid-month Date
            var resultMidMonth = midMonthDate.GetLastMonthFirstDay();
            Assert.NotNull(resultMidMonth);
            Assert.Equal(new DateTime(2025, 3, 1), resultMidMonth);

            // First Day of Month
            var resultFirstDayOfMonth = firstDayOfMonth.GetLastMonthFirstDay();
            Assert.NotNull(resultFirstDayOfMonth);
            Assert.Equal(new DateTime(2025, 3, 1), resultFirstDayOfMonth);

            // January Date (Crossing Year Boundary)
            var resultJanuaryDate = januaryDate.GetLastMonthFirstDay();
            Assert.NotNull(resultJanuaryDate);
            Assert.Equal(new DateTime(2024, 12, 1), resultJanuaryDate);

            // Leap Year Date
            var resultLeapYearDate = leapYearDate.GetLastMonthFirstDay();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 1), resultLeapYearDate);
        }

        [Fact]
        public void GetFirstDayOfNextMonth_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.GetNextMonthFirstDay();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetFirstDayOfNextMonth_ShouldReturnFirstDayOfNextMonth_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 15);

            // Act
            var result = sourceDateTime.GetNextMonthFirstDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 5, 1), result);
        }

        [Fact]
        public void GetFirstDayOfNextMonth_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? midMonthDate = new DateTime(2025, 4, 15);
            DateTime? lastDayOfMonth = new DateTime(2025, 4, 30);
            DateTime? decemberDate = new DateTime(2025, 12, 15); // Crossing year boundary
            DateTime? leapYearDate = new DateTime(2024, 2, 29); // Leap year scenario

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.GetNextMonthFirstDay());

            // Mid-month Date
            var resultMidMonth = midMonthDate.GetNextMonthFirstDay();
            Assert.NotNull(resultMidMonth);
            Assert.Equal(new DateTime(2025, 5, 1), resultMidMonth);

            // Last Day of Month
            var resultLastDayOfMonth = lastDayOfMonth.GetNextMonthFirstDay();
            Assert.NotNull(resultLastDayOfMonth);
            Assert.Equal(new DateTime(2025, 5, 1), resultLastDayOfMonth);

            // December Date (Crossing Year Boundary)
            var resultDecemberDate = decemberDate.GetNextMonthFirstDay();
            Assert.NotNull(resultDecemberDate);
            Assert.Equal(new DateTime(2026, 1, 1), resultDecemberDate);

            // Leap Year Date
            var resultLeapYearDate = leapYearDate.GetNextMonthFirstDay();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 3, 1), resultLeapYearDate);
        }

        [Fact]
        public void GetFirstDayOfMonth_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.CurrentMonthFirstDay();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetFirstDayOfMonth_ShouldReturnFirstDayOfMonth_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 15);

            // Act
            var result = sourceDateTime.CurrentMonthFirstDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 1), result);
        }

        [Fact]
        public void GetFirstDayOfMonth_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? midMonthDate = new DateTime(2025, 4, 15);
            DateTime? firstDayOfMonth = new DateTime(2025, 4, 1);
            DateTime? leapYearDate = new DateTime(2024, 2, 29); // Leap year scenario

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.CurrentMonthFirstDay());

            // Mid-month Date
            var resultMidMonth = midMonthDate.CurrentMonthFirstDay();
            Assert.NotNull(resultMidMonth);
            Assert.Equal(new DateTime(2025, 4, 1), resultMidMonth);

            // First Day of Month
            var resultFirstDayOfMonth = firstDayOfMonth.CurrentMonthFirstDay();
            Assert.NotNull(resultFirstDayOfMonth);
            Assert.Equal(new DateTime(2025, 4, 1), resultFirstDayOfMonth);

            // Leap Year Date
            var resultLeapYearDate = leapYearDate.CurrentMonthFirstDay();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 1), resultLeapYearDate);
        }

        [Fact]
        public void GetLastDayOfMonth_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetLastDayOfMonth_ShouldReturnLastDayOfMonth_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 15);

            // Act
            var result = sourceDateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 30), result);
        }

        [Fact]
        public void GetLastDayOfMonth_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? midMonthDate = new DateTime(2025, 4, 15);
            DateTime? lastDayOfMonth = new DateTime(2025, 4, 30);
            DateTime? leapYearDate = new DateTime(2024, 2, 15); // Leap year February
            DateTime? nonLeapYearDate = new DateTime(2023, 2, 15); // Non-leap year February
            DateTime? decemberDate = new DateTime(2025, 12, 15); // December

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.GetCurrentMonthLastDay());

            // Mid-month Date
            var resultMidMonth = midMonthDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultMidMonth);
            Assert.Equal(new DateTime(2025, 4, 30), resultMidMonth);

            // Last Day of Month
            var resultLastDayOfMonth = lastDayOfMonth.GetCurrentMonthLastDay();
            Assert.NotNull(resultLastDayOfMonth);
            Assert.Equal(new DateTime(2025, 4, 30), resultLastDayOfMonth);

            // Leap Year February
            var resultLeapYearDate = leapYearDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 29), resultLeapYearDate);

            // Non-Leap Year February
            var resultNonLeapYearDate = nonLeapYearDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultNonLeapYearDate);
            Assert.Equal(new DateTime(2023, 2, 28), resultNonLeapYearDate);

            // December
            var resultDecemberDate = decemberDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultDecemberDate);
            Assert.Equal(new DateTime(2025, 12, 31), resultDecemberDate);
        }

        [Fact]
        public void GetSecondDayToLastOfMonth_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.GetLastOfMonthSecondDay();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetSecondDayToLastOfMonth_ShouldReturnSecondToLastDayOfMonth_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 15);

            // Act
            var result = sourceDateTime.GetLastOfMonthSecondDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 29), result);
        }

        [Fact]
        public void GetSecondDayToLastOfMonth_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? midMonthDate = new DateTime(2025, 4, 15);
            DateTime? lastDayOfMonth = new DateTime(2025, 4, 30);
            DateTime? leapYearDate = new DateTime(2024, 2, 15); // Leap year February
            DateTime? nonLeapYearDate = new DateTime(2023, 2, 15); // Non-leap year February
            DateTime? decemberDate = new DateTime(2025, 12, 15); // December

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.GetLastOfMonthSecondDay());

            // Mid-month Date
            var resultMidMonth = midMonthDate.GetLastOfMonthSecondDay();
            Assert.NotNull(resultMidMonth);
            Assert.Equal(new DateTime(2025, 4, 29), resultMidMonth);

            // Last Day of Month
            var resultLastDayOfMonth = lastDayOfMonth.GetLastOfMonthSecondDay();
            Assert.NotNull(resultLastDayOfMonth);
            Assert.Equal(new DateTime(2025, 4, 29), resultLastDayOfMonth);

            // Leap Year February
            var resultLeapYearDate = leapYearDate.GetLastOfMonthSecondDay();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 28), resultLeapYearDate);

            // Non-Leap Year February
            var resultNonLeapYearDate = nonLeapYearDate.GetLastOfMonthSecondDay();
            Assert.NotNull(resultNonLeapYearDate);
            Assert.Equal(new DateTime(2023, 2, 27), resultNonLeapYearDate);

            // December
            var resultDecemberDate = decemberDate.GetLastOfMonthSecondDay();
            Assert.NotNull(resultDecemberDate);
            Assert.Equal(new DateTime(2025, 12, 30), resultDecemberDate);
        }

        [Fact]
        public void CurrentMonthLastDay_ShouldReturnNull_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void CurrentMonthLastDay_ShouldReturnLastDayOfMonth_WhenSourceDateTimeIsValid()
        {
            // Arrange
            DateTime? sourceDateTime = new DateTime(2025, 4, 15);

            // Act
            var result = sourceDateTime.GetCurrentMonthLastDay();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2025, 4, 30), result);
        }

        [Fact]
        public void CurrentMonthLastDay_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? midMonthDate = new DateTime(2025, 4, 15);
            DateTime? lastDayOfMonth = new DateTime(2025, 4, 30);
            DateTime? leapYearDate = new DateTime(2024, 2, 15); // Leap year February
            DateTime? nonLeapYearDate = new DateTime(2023, 2, 15); // Non-leap year February
            DateTime? decemberDate = new DateTime(2025, 12, 15); // December

            // Act & Assert
            // Null DateTime
            Assert.Null(nullDateTime.GetCurrentMonthLastDay());

            // Mid-month Date
            var resultMidMonth = midMonthDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultMidMonth);
            Assert.Equal(new DateTime(2025, 4, 30), resultMidMonth);

            // Last Day of Month
            var resultLastDayOfMonth = lastDayOfMonth.GetCurrentMonthLastDay();
            Assert.NotNull(resultLastDayOfMonth);
            Assert.Equal(new DateTime(2025, 4, 30), resultLastDayOfMonth);

            // Leap Year February
            var resultLeapYearDate = leapYearDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultLeapYearDate);
            Assert.Equal(new DateTime(2024, 2, 29), resultLeapYearDate);

            // Non-Leap Year February
            var resultNonLeapYearDate = nonLeapYearDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultNonLeapYearDate);
            Assert.Equal(new DateTime(2023, 2, 28), resultNonLeapYearDate);

            // December
            var resultDecemberDate = decemberDate.GetCurrentMonthLastDay();
            Assert.NotNull(resultDecemberDate);
            Assert.Equal(new DateTime(2025, 12, 31), resultDecemberDate);
        }

        [Fact]
        public void IsWeekend_ShouldReturnFalse_WhenSourceDateTimeIsNull()
        {
            // Arrange
            DateTime? sourceDateTime = null;

            // Act
            var result = sourceDateTime.IsWeekendDay();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsWeekend_ShouldReturnTrue_WhenSourceDateTimeIsWeekend()
        {
            // Arrange
            DateTime? saturday = new DateTime(2025, 4, 26); // Saturday
            DateTime? sunday = new DateTime(2025, 4, 27);   // Sunday

            // Act
            var resultSaturday = saturday.IsWeekendDay();
            var resultSunday = sunday.IsWeekendDay();

            // Assert
            Assert.True(resultSaturday);
            Assert.True(resultSunday);
        }

        [Fact]
        public void IsWeekend_ShouldReturnFalse_WhenSourceDateTimeIsWeekday()
        {
            // Arrange
            DateTime? monday = new DateTime(2025, 4, 28);   // Monday
            DateTime? tuesday = new DateTime(2025, 4, 29);  // Tuesday
            DateTime? wednesday = new DateTime(2025, 4, 30); // Wednesday
            DateTime? thursday = new DateTime(2025, 5, 1);  // Thursday
            DateTime? friday = new DateTime(2025, 5, 2);    // Friday

            // Act
            var resultMonday = monday.IsWeekendDay();
            var resultTuesday = tuesday.IsWeekendDay();
            var resultWednesday = wednesday.IsWeekendDay();
            var resultThursday = thursday.IsWeekendDay();
            var resultFriday = friday.IsWeekendDay();

            // Assert
            Assert.False(resultMonday);
            Assert.False(resultTuesday);
            Assert.False(resultWednesday);
            Assert.False(resultThursday);
            Assert.False(resultFriday);
        }

        [Fact]
        public void IsWeekend_ShouldHandleVariousDateTimeInputs()
        {
            // Arrange
            DateTime? nullDateTime = null;
            DateTime? saturday = new DateTime(2025, 4, 26); // Saturday
            DateTime? sunday = new DateTime(2025, 4, 27);   // Sunday
            DateTime? monday = new DateTime(2025, 4, 28);   // Monday

            // Act & Assert
            // Null DateTime
            Assert.False(nullDateTime.IsWeekendDay());

            // Weekend Dates
            Assert.True(saturday.IsWeekendDay());
            Assert.True(sunday.IsWeekendDay());

            // Weekday Date
            Assert.False(monday.IsWeekendDay());
        }
    }
}
