using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_GetColumnNamesTests
    {
        [Fact]
        public void GetColumnNames_Should_Return_All_Column_Names()
        {
            // Arrange
            var columnNames = new[] { "Id", "Name", "Age" };
            var record = Substitute.For<IDataRecord>();
            record.FieldCount.Returns(columnNames.Length);
            for (int i = 0; i < columnNames.Length; i++)
            {
                record.GetName(i).Returns(columnNames[i]);
            }

            // Act
            var result = record.GetColumnNames();

            // Assert
            result.ShouldBeOfType<List<string>>();
            result.ShouldBe(columnNames);
        }

        [Fact]
        public void GetColumnNames_Should_Return_Empty_When_No_Columns()
        {
            // Arrange
            var record = Substitute.For<IDataRecord>();
            record.FieldCount.Returns(0);

            // Act
            var result = record.GetColumnNames();

            // Assert
            result.ShouldBeEmpty();
        }
    }
}