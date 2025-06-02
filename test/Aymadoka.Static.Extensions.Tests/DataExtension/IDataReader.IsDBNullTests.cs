using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class IDataReader_IsDBNullTests
    {
        [Fact]
        public void IsDBNull_Should_Return_True_When_Value_Is_DBNull()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            var columnName = "TestColumn";
            var ordinal = 1;
            reader.GetOrdinal(columnName).Returns(ordinal);
            reader.IsDBNull(ordinal).Returns(true);

            // Act
            var result = reader.IsDBNull(columnName);

            // Assert
            result.ShouldBeTrue();
        }

        [Fact]
        public void IsDBNull_Should_Return_False_When_Value_Is_Not_DBNull()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            var columnName = "TestColumn";
            var ordinal = 2;
            reader.GetOrdinal(columnName).Returns(ordinal);
            reader.IsDBNull(ordinal).Returns(false);

            // Act
            var result = reader.IsDBNull(columnName);

            // Assert
            result.ShouldBeFalse();
        }
    }
}