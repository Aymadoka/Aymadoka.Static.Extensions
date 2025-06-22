using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class DataColumnCollection_AddRangeTests
    {
        [Fact]
        public void AddRange_ShouldAddAllColumns()
        {
            // Arrange
            var table = new DataTable();
            var columns = new[] { "Id", "Name", "Age" };

            // Act
            table.Columns.AddRange(columns);

            // Assert
            Assert.Equal(3, table.Columns.Count);
            Assert.Equal("Id", table.Columns[0].ColumnName);
            Assert.Equal("Name", table.Columns[1].ColumnName);
            Assert.Equal("Age", table.Columns[2].ColumnName);
        }

        [Fact]
        public void AddRange_WithNoColumns_ShouldNotThrow()
        {
            // Arrange
            var table = new DataTable();

            // Act
            table.Columns.AddRange();

            // Assert
            Assert.Empty(table.Columns);
        }
    }
}