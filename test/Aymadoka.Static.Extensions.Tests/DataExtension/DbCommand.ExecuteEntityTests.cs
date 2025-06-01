using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteEntityTests
    {
        public class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void ExecuteEntity_Should_Map_First_Row_To_Entity()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.Read().Returns(true, false);
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader["Id"].Returns(42);
            reader["Name"].Returns("Aymadoka");

            var command = Substitute.For<DbCommand>();
            command.ExecuteReader().Returns(reader);

            // Act
            var result = command.ExecuteEntity<TestEntity>();

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(42);
            result.Name.ShouldBe("Aymadoka");
        }

        [Fact]
        public void ExecuteEntity_Should_Throw_When_No_Data()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.Read().Returns(false);

            var command = Substitute.For<DbCommand>();
            command.ExecuteReader().Returns(reader);

            // Act & Assert
            Should.Throw<InvalidOperationException>(() =>
            {
                command.ExecuteEntity<TestEntity>();
            });
        }
    }
}