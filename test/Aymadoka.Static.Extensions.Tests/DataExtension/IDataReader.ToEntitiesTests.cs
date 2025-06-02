using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_ToEntitiesTests
    {
        public class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Score;
        }

        [Fact]
        public void ToEntities_Should_Map_Properties_And_Fields_Correctly()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(3);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetName(2).Returns("Score");

            var callCount = 0;
            var data = new List<object[]>
            {
                new object[] { 1, "Alice", 95.5 },
                new object[] { 2, "Bob", 88.0 }
            };

            reader.Read().Returns(_ => callCount < data.Count, _ => ++callCount < data.Count);
            reader[Arg.Any<string>()].Returns(ci =>
            {
                var current = data[callCount];
                return ci.Arg<string>() switch
                {
                    "Id" => current[0],
                    "Name" => current[1],
                    "Score" => current[2],
                    _ => null
                };
            });

            // Act
            var result = reader.ToEntities<TestEntity>().ToList();

            // Assert
            result.Count.ShouldBe(2);
            result[0].Id.ShouldBe(1);
            result[0].Name.ShouldBe("Alice");
            result[0].Score.ShouldBe(95.5);
            result[1].Id.ShouldBe(2);
            result[1].Name.ShouldBe("Bob");
            result[1].Score.ShouldBe(88.0);
        }

        [Fact]
        public void ToEntities_Should_Return_Empty_If_No_Rows()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.Read().Returns(false);

            // Act
            var result = reader.ToEntities<TestEntity>().ToList();

            // Assert
            result.ShouldBeEmpty();
        }

        [Fact]
        public void ToEntities_Should_Ignore_Extra_Fields()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(4);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetName(2).Returns("Score");
            reader.GetName(3).Returns("Extra");

            var callCount = 0;
            var data = new List<object[]>
            {
                new object[] { 1, "Alice", 95.5, "ignore" }
            };

            reader.Read().Returns(_ => callCount < data.Count, _ => ++callCount < data.Count);
            reader[Arg.Any<string>()].Returns(ci =>
            {
                var current = data[callCount];
                return ci.Arg<string>() switch
                {
                    "Id" => current[0],
                    "Name" => current[1],
                    "Score" => current[2],
                    "Extra" => current[3],
                    _ => null
                };
            });

            // Act
            var result = reader.ToEntities<TestEntity>().ToList();

            // Assert
            result.Count.ShouldBe(1);
            result[0].Id.ShouldBe(1);
            result[0].Name.ShouldBe("Alice");
            result[0].Score.ShouldBe(95.5);
        }
    }
}