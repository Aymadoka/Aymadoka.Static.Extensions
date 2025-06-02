using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using NSubstitute;
using Shouldly;
using Xunit;
using Aymadoka.Static.DataExtension;

namespace Aymadoka.Static.Extensions.Tests.DataExtension
{
    public class SqlConnection_ExecuteEntitiesTests
    {
        public class DummyEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void ExecuteEntities_Should_Map_Entities_From_Reader()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            // 模拟 IDataReader 行和列
            var callCount = 0;
            reader.Read().Returns(_ =>
            {
                callCount++;
                return callCount <= 2;
            });

            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetFieldType(0).Returns(typeof(int));
            reader.GetFieldType(1).Returns(typeof(string));
            reader[0].Returns(1, 2);
            reader[1].Returns("Alice", "Bob");

            // Act
            var result = connection.ExecuteEntities<DummyEntity>("SELECT * FROM Dummy", null, CommandType.Text, null);

            // Assert
            var list = new List<DummyEntity>(result);
            list.Count.ShouldBe(2);
            list[0].Id.ShouldBe(1);
            list[0].Name.ShouldBe("Alice");
            list[1].Id.ShouldBe(2);
            list[1].Name.ShouldBe("Bob");
        }

        [Fact]
        public void ExecuteEntities_Should_Handle_Null_Parameters()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            reader.Read().Returns(false);

            // Act
            var result = connection.ExecuteEntities<DummyEntity>("SELECT * FROM Dummy", null, CommandType.Text, null);

            // Assert
            result.ShouldBeEmpty();
        }

        [Fact]
        public void ExecuteEntities_WithCommandFactory_ShouldReturnEntities()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var reader = Substitute.For<IDataReader>();

            connection.CreateCommand().Returns(command);
            command.ExecuteReader().Returns(reader);

            // 模拟 IDataReader 行和字段
            var readCount = 0;
            reader.Read().Returns(_ => readCount++ == 0, _ => false);
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader["Id"].Returns(123);
            reader["Name"].Returns("TestName");

            // Act
            var result = connection.ExecuteEntities<DummyEntity>(cmd =>
            {
                cmd.CommandText = "SELECT Id, Name FROM Dummy";
            });

            // Assert
            var list = new List<DummyEntity>(result);
            list.Count.ShouldBe(1);
            list[0].Id.ShouldBe(123);
            list[0].Name.ShouldBe("TestName");
            command.Received(1).ExecuteReader();
            connection.Received(1).CreateCommand();
        }
    }
}