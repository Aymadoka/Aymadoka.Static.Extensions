using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class DataTable_LastRowTests
    {
        [Fact]
        public void LastRow_ReturnsLastRow_WhenTableHasRows()
        {
            // Arrange
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Rows.Add(1, "Alice");
            table.Rows.Add(2, "Bob");

            // Act
            var lastRow = table.LastRow();

            // Assert
            Assert.Equal(2, lastRow["Id"]);
            Assert.Equal("Bob", lastRow["Name"]);
        }

        [Fact]
        public void LastRow_ThrowsIndexOutOfRangeException_WhenTableIsEmpty()
        {
            // Arrange
            var table = new DataTable();

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => table.LastRow());
        }
    }
}