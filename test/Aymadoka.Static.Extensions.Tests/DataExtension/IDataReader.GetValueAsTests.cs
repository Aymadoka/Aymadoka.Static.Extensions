using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_GetValueAsTests
    {
        [Fact]
        public void GetValueAs_ByIndex_ShouldReturnCorrectValue()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetValue(0).Returns(123);

            // Act
            var result = reader.GetValueAs<int>(0);

            // Assert
            result.ShouldBe(123);
        }

        [Fact]
        public void GetValueAs_ByColumnName_ShouldReturnCorrectValue()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetOrdinal("Name").Returns(1);
            reader.GetValue(1).Returns("TestName");

            // Act
            var result = reader.GetValueAs<string>("Name");

            // Assert
            result.ShouldBe("TestName");
        }

        [Fact]
        public void GetValueAs_ByIndex_WithNull_ShouldThrowInvalidCastException()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetValue(0).Returns(DBNull.Value);

            // Act & Assert
            Should.Throw<InvalidCastException>(() => reader.GetValueAs<int>(0));
        }

        [Fact]
        public void GetValueAs_ByColumnName_WithNull_ShouldThrowInvalidCastException()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetOrdinal("Age").Returns(2);
            reader.GetValue(2).Returns(DBNull.Value);

            // Act & Assert
            Should.Throw<InvalidCastException>(() => reader.GetValueAs<int>("Age"));
        }
    }
}