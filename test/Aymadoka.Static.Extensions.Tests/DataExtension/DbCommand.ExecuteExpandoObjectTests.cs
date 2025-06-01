using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteExpandoObjectTests
    {
        [Fact]
        public void ExecuteExpandoObject_Should_Return_ExpandoObject_When_Data_Exists()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.Read().Returns(true, false);
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader[0].Returns(1);
            reader[1].Returns("Test");

            var command = Substitute.For<DbCommand>();
            command.ExecuteReader().Returns(reader);

            // Act
            dynamic result = command.ExecuteExpandoObject();

            // Assert
            result.ShouldNotBeNull();
            ((int)result.Id).ShouldBe(1);
            ((string)result.Name).ShouldBe("Test");
        }

        [Fact]
        public void ExecuteExpandoObject_Should_Return_Null_When_No_Data()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.Read().Returns(false);

            var command = Substitute.For<DbCommand>();
            command.ExecuteReader().Returns(reader);

            // Act
            dynamic result = command.ExecuteExpandoObject();

            // Assert
            ((object)result).ShouldBeNull();
        }
    }
}