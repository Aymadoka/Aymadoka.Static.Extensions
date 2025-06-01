using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbConnection_ExecuteExpandoObjectTests
    {
        [Fact]
        public void Should_return_expando_object_with_expected_properties()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            command.When(x => x.Parameters.AddRange(Arg.Any<DbParameter[]>())).DoNotCallBase();

            reader.Read().Returns(true);
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetValue(0).Returns(123);
            reader.GetValue(1).Returns("John");

            // Act
            dynamic result = connection.ExecuteExpandoObject("select Id, Name from Users", null, CommandType.Text, null);

            // Assert
            ((object)result).ShouldNotBeNull();
            ((int)result.Id).ShouldBe(123);
            ((string)result.Name).ShouldBe("John");
        }

        [Fact]
        public void Should_return_expando_object_when_no_parameters()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            reader.Read().Returns(true);
            reader.FieldCount.Returns(1);
            reader.GetName(0).Returns("Value");
            reader.GetValue(0).Returns(42);

            // Act
            dynamic result = connection.ExecuteExpandoObject("select 42 as Value", null, CommandType.Text, null);

            // Assert
            ((object)result).ShouldNotBeNull();
            ((int)result.Value).ShouldBe(42);
        }

        [Fact]
        public void Should_return_empty_expando_object_when_no_data()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            reader.Read().Returns(false);

            // Act
            dynamic result = connection.ExecuteExpandoObject("select 1", null, CommandType.Text, null);

            // Assert
            ((object)result).ShouldNotBeNull();
            var dict = (IDictionary<string, object>)result;
            dict.Count.ShouldBe(0);
        }

        [Fact]
        public void Should_return_expando_object_with_expected_properties_using_command_factory()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            reader.Read().Returns(true);
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetValue(0).Returns(456);
            reader.GetValue(1).Returns("Alice");

            // Act
            dynamic result = connection.ExecuteExpandoObject(cmd =>
            {
                cmd.CommandText = "select Id, Name from Users";
                cmd.CommandType = CommandType.Text;
            });

            // Assert
            ((object)result).ShouldNotBeNull();
            ((int)result.Id).ShouldBe(456);
            ((string)result.Name).ShouldBe("Alice");
        }

        [Fact]
        public void Should_return_empty_expando_object_when_no_data_using_command_factory()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            reader.Read().Returns(false);

            // Act
            dynamic result = connection.ExecuteExpandoObject(cmd =>
            {
                cmd.CommandText = "select 1";
                cmd.CommandType = CommandType.Text;
            });

            // Assert
            ((object)result).ShouldNotBeNull();
            var dict = (IDictionary<string, object>)result;
            dict.Count.ShouldBe(0);
        }
    }
}