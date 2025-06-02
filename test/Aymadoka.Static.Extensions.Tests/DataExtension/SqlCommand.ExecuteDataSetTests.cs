using Microsoft.Data.SqlClient;
using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class SqlCommand_ExecuteDataSetTests
    {
        [Fact]
        public void ExecuteDataSet_ShouldReturnFilledDataSet()
        {
            // Arrange
            var command = Substitute.For<SqlCommand>();
            var dataTable = new DataTable("TestTable");
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Rows.Add(1);

            var dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            // Substitute SqlDataAdapter
            var dataAdapter = Substitute.ForPartsOf<SqlDataAdapter>(command);
            dataAdapter.When(x => x.Fill(Arg.Any<DataSet>()))
                       .Do(callInfo =>
                       {
                           var ds = callInfo.Arg<DataSet>();
                           ds.Tables.Add(dataTable.Copy());
                       });

            // Act
            DataSet result;
            using (NSubstituteExtensions.OverrideSqlDataAdapter(dataAdapter))
            {
                result = command.ExecuteDataSet();
            }

            // Assert
            result.ShouldNotBeNull();
            result.Tables.Count.ShouldBe(1);
            result.Tables[0].TableName.ShouldBe("TestTable");
            result.Tables[0].Rows.Count.ShouldBe(1);
            result.Tables[0].Rows[0]["Id"].ShouldBe(1);
        }
    }

    // Helper to override SqlDataAdapter in the extension method for testing
    internal class NSubstituteExtensions : IDisposable
    {
        private static SqlDataAdapter _originalAdapter;
        private static SqlDataAdapter _testAdapter;

        public static IDisposable OverrideSqlDataAdapter(SqlDataAdapter testAdapter)
        {
            _testAdapter = testAdapter;
            _originalAdapter = null;
            return new NSubstituteExtensions();
        }

        public void Dispose()
        {
            _testAdapter = null;
        }
    }
}