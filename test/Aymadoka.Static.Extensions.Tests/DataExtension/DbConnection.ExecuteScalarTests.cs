using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{

    public class DbConnection_ExecuteScalarTests
    {
        [Fact]
        public void ExecuteScalar_所有参数_应设置属性并返回结果()
        {
            // Arrange
            var expected = 123;
            var cmdText = "SELECT COUNT(*) FROM Users";
            var commandType = CommandType.Text;
            var transaction = Substitute.For<DbTransaction>();
            var parameters = new[] { Substitute.For<DbParameter>() };

            var command = Substitute.For<DbCommand>();
            command.ExecuteScalar().Returns(expected);

            var connection = Substitute.For<DbConnection>();
            connection.CreateCommand().Returns(command);

            // Act
            var result = connection.ExecuteScalar(cmdText, parameters, commandType, transaction);

            // Assert
            result.ShouldBe(expected);
            command.CommandText.ShouldBe(cmdText);
            command.CommandType.ShouldBe(commandType);
            command.Transaction.ShouldBe(transaction);
            command.Received(1).Parameters.AddRange(parameters);
            command.Received(1).ExecuteScalar();
            command.Received(1).Dispose();
        }

        [Fact]
        public void ExecuteScalar_参数为null_不应调用AddRange()
        {
            // Arrange
            var expected = "result";
            var cmdText = "SELECT Name FROM Users";
            var commandType = CommandType.StoredProcedure;
            var transaction = Substitute.For<DbTransaction>();

            var command = Substitute.For<DbCommand>();
            command.ExecuteScalar().Returns(expected);

            var connection = Substitute.For<DbConnection>();
            connection.CreateCommand().Returns(command);

            // Act
            var result = connection.ExecuteScalar(cmdText, null, commandType, transaction);

            // Assert
            result.ShouldBe(expected);
            command.Received(0).Parameters.AddRange(Arg.Any<DbParameter[]>());
            command.Received(1).ExecuteScalar();
            command.Received(1).Dispose();
        }

        [Fact]
        public void ExecuteScalar_CommandFactory_InvokesFactoryAndReturnsScalar()
        {
            // Arrange
            var expected = 42;
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteScalar().Returns(expected);

            bool factoryCalled = false;
            Action<DbCommand> factory = cmd =>
            {
                factoryCalled = true;
                cmd.ShouldBe(dbCommand);
                // 可以在这里设置参数等
            };

            // Act
            var result = dbConnection.ExecuteScalar(factory);

            // Assert
            factoryCalled.ShouldBeTrue();
            result.ShouldBe(expected);
            dbConnection.Received(1).CreateCommand();
            dbCommand.Received(1).ExecuteScalar();
        }
    }
}