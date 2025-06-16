using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class DataTable_ToEntitiesTests
    {
        private class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Value;
        }

        [Fact]
        public void ToEntities_Should_Map_Properties_And_Fields()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Value", typeof(double));

            var row = table.NewRow();
            row["Id"] = 1;
            row["Name"] = "Test";
            row["Value"] = 3.14;
            table.Rows.Add(row);

            // Act
            var result = table.ToEntities<TestEntity>().ToList();

            // Assert
            Assert.Single(result);
            Assert.Equal(1, result[0].Id);
            Assert.Equal("Test", result[0].Name);
            Assert.Equal(3.14, result[0].Value, 3);
        }

        [Fact]
        public void ToEntities_Should_Handle_EmptyTable()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Value", typeof(double));

            // Act
            var result = table.ToEntities<TestEntity>().ToList();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ToEntities_Should_Ignore_Extra_Columns()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Value", typeof(double));
            table.Columns.Add("Extra", typeof(string));

            var row = table.NewRow();
            row["Id"] = 2;
            row["Name"] = "Extra";
            row["Value"] = 2.71;
            row["Extra"] = "IgnoreMe";
            table.Rows.Add(row);

            // Act
            var result = table.ToEntities<TestEntity>().ToList();

            // Assert
            Assert.Single(result);
            Assert.Equal(2, result[0].Id);
            Assert.Equal("Extra", result[0].Name);
            Assert.Equal(2.71, result[0].Value, 3);
        }

        [Fact]
        public void ToEntities_Should_Handle_Nullable_Values()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Value", typeof(double));

            var row = table.NewRow();
            row["Id"] = DBNull.Value;
            row["Name"] = DBNull.Value;
            row["Value"] = DBNull.Value;
            table.Rows.Add(row);

            // Act
            var result = table.ToEntities<TestEntity>().ToList();

            // Assert
            Assert.Single(result);
            Assert.Equal(0, result[0].Id);
            Assert.Equal(null, result[0].Name);
            Assert.Equal(0, result[0].Value, 3);
        }
    }
}
