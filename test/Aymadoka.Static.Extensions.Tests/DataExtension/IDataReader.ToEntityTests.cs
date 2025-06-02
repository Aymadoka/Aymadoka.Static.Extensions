using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_ToEntityTests
    {
        public class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Score;
            public DateTime CreatedAt { get; set; }
        }

        [Fact]
        public void ToEntity_MapsPropertiesAndFields()
        {
            // Arrange
            var columns = new[] { "Id", "Name", "Score", "CreatedAt" };
            var values = new object[] { 123, "TestName", 88.6, new DateTime(2024, 6, 1) };
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(columns.Length);
            reader.GetName(Arg.Any<int>()).Returns(x => columns[(int)x[0]]);
            reader[Arg.Any<string>()].Returns(x =>
            {
                var idx = Array.IndexOf(columns, (string)x[0]);
                return idx >= 0 ? values[idx] : null;
            });

            // Act
            var entity = reader.ToEntity<TestEntity>();

            // Assert
            entity.Id.ShouldBe(123);
            entity.Name.ShouldBe("TestName");
            entity.Score.ShouldBe(88.6);
            entity.CreatedAt.ShouldBe(new DateTime(2024, 6, 1));
        }

        [Fact]
        public void ToEntity_IgnoresMissingColumns()
        {
            // Arrange
            var columns = new[] { "Id", "Name" };
            var values = new object[] { 1, "Bob" };
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(columns.Length);
            reader.GetName(Arg.Any<int>()).Returns(x => columns[(int)x[0]]);
            reader[Arg.Any<string>()].Returns(x =>
            {
                var idx = Array.IndexOf(columns, (string)x[0]);
                return idx >= 0 ? values[idx] : null;
            });

            // Act
            var entity = reader.ToEntity<TestEntity>();

            // Assert
            entity.Id.ShouldBe(1);
            entity.Name.ShouldBe("Bob");
            entity.Score.ShouldBe(0); // default(double)
            entity.CreatedAt.ShouldBe(default);
        }

        [Fact]
        public void ToEntity_HandlesDBNull()
        {
            // Arrange
            var columns = new[] { "Id", "Name", "Score", "CreatedAt" };
            var values = new object[] { DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value };
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(columns.Length);
            reader.GetName(Arg.Any<int>()).Returns(x => columns[(int)x[0]]);
            reader[Arg.Any<string>()].Returns(x =>
            {
                var idx = Array.IndexOf(columns, (string)x[0]);
                return idx >= 0 ? values[idx] : null;
            });

            // Act
            var entity = reader.ToEntity<TestEntity>();

            // Assert
            entity.Id.ShouldBe(0);
            entity.Name.ShouldBeNull();
            entity.Score.ShouldBe(0);
            entity.CreatedAt.ShouldBe(default);
        }
    }
}