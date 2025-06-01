using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class DataRow_ToExpandoObjectTests
    {
        [Fact]
        public void ToExpandoObject_ShouldReturnExpandoObjectWithAllColumns()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Created", typeof(DateTime));

            var row = table.NewRow();
            row["Id"] = 1;
            row["Name"] = "Test";
            row["Created"] = new DateTime(2024, 6, 1, 0, 0, 0, DateTimeKind.Local);
            table.Rows.Add(row);

            // Act
            dynamic expando = row.ToExpandoObject();

            // Assert
            Assert.Equal(1, expando.Id);
            Assert.Equal("Test", expando.Name);
            Assert.Equal(new DateTime(2024, 6, 1, 0, 0, 0, DateTimeKind.Local), expando.Created);
        }

        [Fact]
        public void ToExpandoObject_ShouldHandleDBNull()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Value", typeof(string));
            var row = table.NewRow();
            row["Value"] = DBNull.Value;
            table.Rows.Add(row);

            // Act
            dynamic expando = row.ToExpandoObject();

            // Assert
            Assert.Equal(DBNull.Value, ((IDictionary<string, object>)expando)["Value"]);
        }

        [Fact]
        public void ToExpandoObject_ShouldReturnEmptyExpandoForNoColumns()
        {
            // Arrange
            var table = new DataTable();
            var row = table.NewRow();
            table.Rows.Add(row);

            // Act
            dynamic expando = row.ToExpandoObject();

            // Assert
            Assert.Empty((IDictionary<string, object>)expando);
        }
    }
}