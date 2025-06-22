using System.Data.Common;
using NSubstitute;
using Shouldly;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteScalarTo_Tests
    {
        [Fact]
        public void ExecuteScalarTo_Should_Convert_Result_To_Specified_Type()
        {
            // Arrange
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.ExecuteScalar().Returns(123);

            // Act
            var result = dbCommand.ExecuteScalarTo<int>();

            // Assert
            result.ShouldBe(123);
        }

        [Fact]
        public void ExecuteScalarTo_Should_Handle_Null_Result()
        {
            // Arrange
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.ExecuteScalar().Returns((object)null);

            // Act
            var result = dbCommand.ExecuteScalarTo<string>();

            // Assert
            result.ShouldBeNull();
        }

        [Fact]
        public void ExecuteScalarTo_Should_Convert_String_To_Int()
        {
            // Arrange
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.ExecuteScalar().Returns("42");

            // Act
            var result = dbCommand.ExecuteScalarTo<int>();

            // Assert
            result.ShouldBe(42);
        }
    }
}