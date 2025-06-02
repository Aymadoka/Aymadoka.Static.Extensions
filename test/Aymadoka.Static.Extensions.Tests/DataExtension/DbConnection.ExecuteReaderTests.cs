using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{

    public class DbConnection_ExecuteReaderTests
    {
        [Fact]
        public void ExecuteReader_AllParameters_CallsCommandAndReturnsReader()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<DbDataReader>();
            var parameters = new[] { Substitute.For<DbParameter>() };
            var transaction = Substitute.For<DbTransaction>();
            const string cmdText = "SELECT * FROM Test";
            const CommandType commandType = CommandType.Text;

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            // Act
            var result = connection.ExecuteReader(cmdText, parameters, commandType, transaction);

            // Assert
            result.ShouldBe(reader);
            command.Received(1).CommandText = cmdText;
            command.Received(1).CommandType = commandType;
            command.Received(1).Transaction = transaction;
            command.Parameters.Received(1).AddRange(parameters);
            command.Received(1).ExecuteReader();
        }

        [Fact]
        public void ExecuteReader_NullParameters_DoesNotCallAddRange()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<DbDataReader>();
            var transaction = Substitute.For<DbTransaction>();
            const string cmdText = "SELECT * FROM Test";
            const CommandType commandType = CommandType.StoredProcedure;

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            // Act
            var result = connection.ExecuteReader(cmdText, null, commandType, transaction);

            // Assert
            result.ShouldBe(reader);
            command.Parameters.DidNotReceive().AddRange(Arg.Any<DbParameter[]>());
            command.Received(1).ExecuteReader();
        }

        [Fact]
        public void ExecuteReader_CommandFactory_InvokesFactoryAndReturnsReader()
        {
            // Arrange
            var connection = Substitute.For<DbConnection>();
            var command = Substitute.For<DbCommand>();
            var reader = Substitute.For<DbDataReader>();
            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            bool factoryCalled = false;
            void Factory(DbCommand cmd)
            {
                factoryCalled = true;
                cmd.ShouldBe(command);
            }

            // Act
            var result = connection.ExecuteReader(Factory);

            // Assert
            factoryCalled.ShouldBeTrue();
            result.ShouldBe(reader);
            command.Received(1).ExecuteReader();
        }
    }
}