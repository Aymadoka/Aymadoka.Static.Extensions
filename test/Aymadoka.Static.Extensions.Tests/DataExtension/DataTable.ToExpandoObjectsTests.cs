using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class DataTable_ToExpandoObjectsTests
    {
        [Fact]
        public void ToExpandoObjects_ReturnsEmptyList_WhenDataTableIsEmpty()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));

            // Act
            var result = table.ToExpandoObjects();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ToExpandoObjects_ConvertsRowsToExpandoObjects()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));

            var row1 = table.NewRow();
            row1["Id"] = 1;
            row1["Name"] = "Alice";
            table.Rows.Add(row1);

            var row2 = table.NewRow();
            row2["Id"] = 2;
            row2["Name"] = "Bob";
            table.Rows.Add(row2);

            // Act
            var result = table.ToExpandoObjects().ToList();

            // Assert
            Assert.Equal(2, result.Count);

            dynamic first = result[0];
            Assert.Equal(1, first.Id);
            Assert.Equal("Alice", first.Name);

            dynamic second = result[1];
            Assert.Equal(2, second.Id);
            Assert.Equal("Bob", second.Name);
        }

        [Fact]
        public void ToExpandoObjects_HandlesNullValues()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));

            var row = table.NewRow();
            row["Id"] = 1;
            row["Name"] = DBNull.Value;
            table.Rows.Add(row);

            // Act
            var result = table.ToExpandoObjects().ToList();

            // Assert
            Assert.Single(result);
            dynamic entity = result[0];
            Assert.Equal(1, entity.Id);
            Assert.Equal(DBNull.Value, entity.Name);
        }
    }
}