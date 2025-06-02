using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Xunit;
using Shouldly;
using NSubstitute;
using Aymadoka.Static.DataExtension;

namespace Aymadoka.Static.Extensions.Tests.DataExtension
{
    public class SqlConnection_ExecuteEntityTests
    {
        public class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void ExecuteEntity_WithParameters_CommandType_Transaction_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();
            var parameters = new[] { new SqlParameter("@id", 1) };
            var transaction = Substitute.For<SqlTransaction>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            command.When(x => x.Parameters.AddRange(parameters)).DoNotCallBase();
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 1, Name = "Test" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test", parameters, CommandType.Text, transaction);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(1);
            result.Name.ShouldBe("Test");
            command.CommandText.ShouldBe("SELECT * FROM Test");
            command.CommandType.ShouldBe(CommandType.Text);
            command.Transaction.ShouldBe(transaction);
        }

        [Fact]
        public void ExecuteEntity_CommandFactory_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 2, Name = "Factory" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, cmd =>
            {
                cmd.CommandText = "SELECT * FROM Test";
            });

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(2);
            result.Name.ShouldBe("Factory");
            command.CommandText.ShouldBe("SELECT * FROM Test");
        }

        [Fact]
        public void ExecuteEntity_CmdText_Only_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 3, Name = "TextOnly" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test");

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(3);
            result.Name.ShouldBe("TextOnly");
            command.CommandText.ShouldBe("SELECT * FROM Test");
            command.CommandType.ShouldBe(CommandType.Text);
        }

        [Fact]
        public void ExecuteEntity_CmdText_And_Transaction_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();
            var transaction = Substitute.For<SqlTransaction>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 4, Name = "WithTran" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test", transaction);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(4);
            result.Name.ShouldBe("WithTran");
            command.Transaction.ShouldBe(transaction);
        }

        [Fact]
        public void ExecuteEntity_CmdText_And_CommandType_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 5, Name = "CmdType" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test", CommandType.StoredProcedure);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(5);
            result.Name.ShouldBe("CmdType");
            command.CommandType.ShouldBe(CommandType.StoredProcedure);
        }

        [Fact]
        public void ExecuteEntity_CmdText_CommandType_Transaction_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();
            var transaction = Substitute.For<SqlTransaction>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 6, Name = "CmdTypeTran" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test", CommandType.Text, transaction);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(6);
            result.Name.ShouldBe("CmdTypeTran");
            command.Transaction.ShouldBe(transaction);
        }

        [Fact]
        public void ExecuteEntity_CmdText_Parameters_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();
            var parameters = new[] { new SqlParameter("@id", 7) };

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 7, Name = "Params" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test", parameters);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(7);
            result.Name.ShouldBe("Params");
        }

        [Fact]
        public void ExecuteEntity_CmdText_Parameters_Transaction_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();
            var parameters = new[] { new SqlParameter("@id", 8) };
            var transaction = Substitute.For<SqlTransaction>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 8, Name = "ParamsTran" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test", parameters, transaction);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(8);
            result.Name.ShouldBe("ParamsTran");
            command.Transaction.ShouldBe(transaction);
        }

        [Fact]
        public void ExecuteEntity_CmdText_Parameters_CommandType_Should_Map_Entity()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();
            var parameters = new[] { new SqlParameter("@id", 9) };

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);
            reader.Read().Returns(true);
            reader.ToEntity<TestEntity>().Returns(new TestEntity { Id = 9, Name = "ParamsCmdType" });

            // Act
            var result = DataExtensions.ExecuteEntity<TestEntity>(connection, "SELECT * FROM Test", parameters, CommandType.Text);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(9);
            result.Name.ShouldBe("ParamsCmdType");
        }
    }
}