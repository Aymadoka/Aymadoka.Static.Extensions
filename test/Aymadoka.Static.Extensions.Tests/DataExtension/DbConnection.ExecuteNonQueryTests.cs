using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{

    public class DbConnection_ExecuteNonQueryTests
    {
        [Fact]
        public void ExecuteNonQuery_AllParameters_ShouldSetPropertiesAndCallExecuteNonQuery()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var transaction = Substitute.For<DbTransaction>();
            var parameters = new[] { Substitute.For<DbParameter>() };

            connection.CreateCommand().Returns(command);
            command.Parameters.Returns(Substitute.For<DbParameterCollection>());

            // Act
            connection.ExecuteNonQuery("SQL", parameters, CommandType.StoredProcedure, transaction);

            // Assert
            command.Received(1).CommandText = "SQL";
            command.Received(1).CommandType = CommandType.StoredProcedure;
            command.Received(1).Transaction = transaction;
            command.Parameters.Received().AddRange(parameters);
            command.Received(1).ExecuteNonQuery();
        }

        [Fact]
        public void ExecuteNonQuery_NullParameters_ShouldNotCallAddRange()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var transaction = Substitute.For<DbTransaction>();

            connection.CreateCommand().Returns(command);
            command.Parameters.Returns(Substitute.For<DbParameterCollection>());

            // Act
            connection.ExecuteNonQuery("SQL", null, CommandType.Text, transaction);

            // Assert
            command.Received(1).CommandText = "SQL";
            command.Received(1).CommandType = CommandType.Text;
            command.Received(1).Transaction = transaction;
            command.Parameters.DidNotReceive().AddRange(Arg.Any<DbParameter[]>());
            command.Received(1).ExecuteNonQuery();
        }

        [Fact]
        public void ExecuteNonQuery_CommandFactory_ShouldInvokeFactoryAndExecute()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            connection.CreateCommand().Returns(command);

            bool factoryCalled = false;
            Action<DbCommand> factory = c =>
            {
                c.ShouldBe(command);
                factoryCalled = true;
            };

            // Act
            connection.ExecuteNonQuery(factory);

            // Assert
            factoryCalled.ShouldBeTrue();
            command.Received(1).ExecuteNonQuery();
        }
    }
}