using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_ToExpandoObjectsTests
    {
        [Fact]
        public void ToExpandoObjects_Should_Return_ExpandoObjects_With_Correct_Values()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");

            var callCount = 0;
            reader.Read().Returns(
                ci => callCount++ == 0, // true on first call, false after
                ci => false
            );

            reader[0].Returns(1);
            reader[1].Returns("Alice");

            // Act
            var result = reader.ToExpandoObjects().ToList();

            // Assert
            result.Count.ShouldBe(1);
            ((IDictionary<string, object>)result[0])["Id"].ShouldBe(1);
            ((IDictionary<string, object>)result[0])["Name"].ShouldBe("Alice");
        }

        [Fact]
        public void ToExpandoObjects_Should_Return_Empty_When_No_Rows()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.Read().Returns(false);

            // Act
            var result = reader.ToExpandoObjects().ToList();

            // Assert
            result.ShouldBeEmpty();
        }

        [Fact]
        public void ToExpandoObjects_Should_Handle_Multiple_Rows()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");

            var callCount = 0;
            reader.Read().Returns(
                ci => callCount++ < 2, // true for first two calls, then false
                ci => false
            );

            reader[0].Returns(ci => callCount == 1 ? 1 : 2);
            reader[1].Returns(ci => callCount == 1 ? "Alice" : "Bob");

            // Act
            var result = reader.ToExpandoObjects().ToList();

            // Assert
            result.Count.ShouldBe(2);
            ((IDictionary<string, object>)result[0])["Id"].ShouldBe(1);
            ((IDictionary<string, object>)result[0])["Name"].ShouldBe("Alice");
            ((IDictionary<string, object>)result[1])["Id"].ShouldBe(2);
            ((IDictionary<string, object>)result[1])["Name"].ShouldBe("Bob");
        }
    }
}