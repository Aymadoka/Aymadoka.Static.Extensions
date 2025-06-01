using System.Data;
using System.Data.Common;
using Aymadoka.Static.DataExtension;
using NSubstitute;
using Shouldly;

namespace Aymadoka.Static.Extensions.Tests.DataExtension
{
    public class DbConnection_ExecuteEntitiesTests
    {
        public class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private static IDataReader CreateTestDataReader()
        {
            var reader = Substitute.For<IDataReader>();
            var callCount = 0;
            reader.Read().Returns(_ => callCount++ == 0);
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader["Id"].Returns(1);
            reader["Name"].Returns("TestName");
            reader.GetValue(0).Returns(1);
            reader.GetValue(1).Returns("TestName");
            return reader;
        }

        [Fact]
        public void ExecuteEntities_WithAllParameters_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var dbTransaction = Substitute.For<DbTransaction>();
            var parameters = new DbParameter[0];
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test", parameters, CommandType.Text, dbTransaction);

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_CommandFactory_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>(cmd =>
            {
                cmd.CommandText = "SELECT * FROM Test";
            });

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_WithCmdTextOnly_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test");

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_WithCmdTextAndTransaction_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var dbTransaction = Substitute.For<DbTransaction>();
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test", dbTransaction);

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_WithCmdTextAndCommandType_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test", CommandType.Text);

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_WithCmdTextCommandTypeAndTransaction_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var dbTransaction = Substitute.For<DbTransaction>();
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test", CommandType.Text, dbTransaction);

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_WithCmdTextAndParameters_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var parameters = new DbParameter[0];
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test", parameters);

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_WithCmdTextParametersAndTransaction_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var dbTransaction = Substitute.For<DbTransaction>();
            var parameters = new DbParameter[0];
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test", parameters, dbTransaction);

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }

        [Fact]
        public void ExecuteEntities_WithCmdTextParametersAndCommandType_ReturnsEntities()
        {
            var dbConnection = Substitute.For<DbConnection>();
            var dbCommand = Substitute.For<DbCommand>();
            var parameters = new DbParameter[0];
            var reader = CreateTestDataReader();

            dbConnection.CreateCommand().Returns(dbCommand);
            dbCommand.ExecuteReader().Returns(reader);

            var result = dbConnection.ExecuteEntities<TestEntity>("SELECT * FROM Test", parameters, CommandType.Text);

            result.ShouldNotBeNull();
            result.ShouldContain(e => e.Id == 1 && e.Name == "TestName");
        }
    }
}