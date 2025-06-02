using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class IDataReader_GetValueToTests
    {
        [Fact]
        public void GetValueTo_ByIndex_Should_Return_Converted_Value()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetValue(0).Returns("123");

            // Act
            var result = reader.GetValueTo<int>(0);

            // Assert
            result.ShouldBe(123);
        }

        [Fact]
        public void GetValueTo_ByColumnName_Should_Return_Converted_Value()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetOrdinal("Age").Returns(1);
            reader.GetValue(1).Returns("45");

            // Act
            var result = reader.GetValueTo<int>("Age");

            // Assert
            result.ShouldBe(45);
        }

        [Fact]
        public void GetValueTo_ByIndex_Should_Handle_Null()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetValue(0).Returns(DBNull.Value);

            // Act
            var result = reader.GetValueTo<string>(0);

            // Assert
            result.ShouldBeNull();
        }

        [Fact]
        public void GetValueTo_ByColumnName_Should_Handle_Null()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.GetOrdinal("Name").Returns(2);
            reader.GetValue(2).Returns(DBNull.Value);

            // Act
            var result = reader.GetValueTo<string>("Name");

            // Assert
            result.ShouldBeNull();
        }
    }
}