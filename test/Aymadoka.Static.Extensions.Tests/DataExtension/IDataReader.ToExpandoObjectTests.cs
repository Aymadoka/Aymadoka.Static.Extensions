using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_ToExpandoObjectTests
    {
        [Fact]
        public void ToExpandoObject_Should_Return_ExpandoObject_With_Correct_Properties()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(3);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetName(2).Returns("Age");
            reader[0].Returns(1);
            reader[1].Returns("Alice");
            reader[2].Returns(30);

            // Act
            dynamic result = reader.ToExpandoObject();

            // Assert
            ((IDictionary<string, object>)result).Count.ShouldBe(3);
            ((IDictionary<string, object>)result).ShouldContainKey("Id");
            ((IDictionary<string, object>)result).ShouldContainKey("Name");
            ((IDictionary<string, object>)result).ShouldContainKey("Age");
            result.Id.ShouldBe(1);
            result.Name.ShouldBe("Alice");
            result.Age.ShouldBe(30);
        }

        [Fact]
        public void ToExpandoObject_Should_Handle_Empty_Reader()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(0);

            // Act
            dynamic result = reader.ToExpandoObject();

            // Assert
            ((IDictionary<string, object>)result).Count.ShouldBe(0);
        }

        [Fact]
        public void ToExpandoObject_Should_Handle_Null_Values()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Col1");
            reader.GetName(1).Returns("Col2");
            reader[0].Returns(DBNull.Value);
            reader[1].Returns("Test");

            // Act
            dynamic result = reader.ToExpandoObject();

            // Assert
            ((IDictionary<string, object>)result).Count.ShouldBe(2);
            result.Col1.ShouldBe(DBNull.Value);
            result.Col2.ShouldBe("Test");
        }
    }
}