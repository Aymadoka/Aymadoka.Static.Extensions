using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteExpandoObjectsTests
    {
        [Fact]
        public void ExecuteExpandoObjects_Should_Return_ExpandoObjects()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            var readCount = 0;
            reader.Read().Returns(_ => readCount++ == 0);
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetValue(0).Returns(42);
            reader.GetValue(1).Returns("Alice");

            var command = Substitute.For<DbCommand>();
            command.ExecuteReader().Returns(reader);

            // Act
            var result = command.ExecuteExpandoObjects().ToList();

            // Assert
            result.Count.ShouldBe(1);
            ((IDictionary<string, object>)result[0])["Id"].ShouldBe(42);
            ((IDictionary<string, object>)result[0])["Name"].ShouldBe("Alice");
        }
    }
}