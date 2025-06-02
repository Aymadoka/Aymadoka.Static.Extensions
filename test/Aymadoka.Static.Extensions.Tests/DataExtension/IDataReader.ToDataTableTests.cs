using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_ToDataTableTests
    {
        [Fact]
        public void ToDataTable_ShouldLoadDataCorrectly()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(2);
            reader.GetName(0).Returns("Id");
            reader.GetName(1).Returns("Name");
            reader.GetFieldType(0).Returns(typeof(int));
            reader.GetFieldType(1).Returns(typeof(string));
            reader.Read().Returns(true, false);
            reader.GetValue(0).Returns(1);
            reader.GetValue(1).Returns("Test");
            reader.IsDBNull(Arg.Any<int>()).Returns(false);

            // Act
            var dt = reader.ToDataTable();

            // Assert
            dt.ShouldNotBeNull();
            dt.Columns.Count.ShouldBe(2);
            dt.Columns[0].ColumnName.ShouldBe("Id");
            dt.Columns[1].ColumnName.ShouldBe("Name");
            dt.Rows.Count.ShouldBe(1);
            dt.Rows[0][0].ShouldBe(1);
            dt.Rows[0][1].ShouldBe("Test");
        }
    }
}