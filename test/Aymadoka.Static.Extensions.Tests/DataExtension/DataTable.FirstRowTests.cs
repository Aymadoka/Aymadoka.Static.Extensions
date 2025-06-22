using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class DataTable_FirstRowTests
    {
        [Fact]
        public void FirstRow_ReturnsFirstRow_WhenTableHasRows()
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
            var result = table.FirstRow();

            // Assert
            Assert.Equal(1, result["Id"]);
            Assert.Equal("Alice", result["Name"]);
        }

        [Fact]
        public void FirstRow_ThrowsIndexOutOfRangeException_WhenTableIsEmpty()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => table.FirstRow());
        }
    }
}