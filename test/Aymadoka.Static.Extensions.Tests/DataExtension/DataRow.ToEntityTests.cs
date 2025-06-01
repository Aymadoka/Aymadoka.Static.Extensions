using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class DataRow_ToEntityTests
    {
        private class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Score;
        }

        [Fact]
        public void ToEntity_Should_Map_Properties_And_Fields()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(double));

            var row = table.NewRow();
            row["Id"] = 1;
            row["Name"] = "Alice";
            row["Score"] = 99.5;
            table.Rows.Add(row);

            // Act
            var entity = row.ToEntity<TestEntity>();

            // Assert
            Assert.Equal(1, entity.Id);
            Assert.Equal("Alice", entity.Name);
            Assert.Equal(99.5, entity.Score);
        }

        [Fact]
        public void ToEntity_Should_Handle_Missing_Columns()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            var row = table.NewRow();
            row["Id"] = 42;
            table.Rows.Add(row);

            // Act
            var entity = row.ToEntity<TestEntity>();

            // Assert
            Assert.Equal(42, entity.Id);
            Assert.Null(entity.Name);
            Assert.Equal(0, entity.Score);
        }

        [Fact]
        public void ToEntity_Should_Convert_Types()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Score", typeof(string));
            var row = table.NewRow();
            row["Id"] = "123";
            row["Score"] = "88.8";
            table.Rows.Add(row);

            // Act
            var entity = row.ToEntity<TestEntity>();

            // Assert
            Assert.Equal(123, entity.Id);
            Assert.Equal(88.8, entity.Score);
        }
    }
}