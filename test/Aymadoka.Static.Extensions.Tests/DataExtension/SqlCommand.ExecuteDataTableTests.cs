using Microsoft.Data.SqlClient;
using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class SqlCommand_ExecuteDataTableTests
    {
        [Fact]
        public void ExecuteDataTable_Should_Return_DataTable_With_Expected_Data()
        {
            // Arrange
            var mockConnection = Substitute.For<IDbConnection>();
            var command = new SqlCommand("SELECT 1 AS TestColumn");
            // 这里需要真实数据库环境，NSubstitute 不能 mock SqlCommand 的行为
            // 所以此测试仅演示 Shouldly 断言用法

            using (var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;"))
            {
                connection.Open();
                using (var realCommand = connection.CreateCommand())
                {
                    realCommand.CommandText = "SELECT TOP 1 name FROM sys.databases";
                    var dt = ((SqlCommand)realCommand).ExecuteDataTable();

                    dt.ShouldNotBeNull();
                    dt.Rows.Count.ShouldBeGreaterThan(0);
                    dt.Columns.Contains("name").ShouldBeTrue();
                }
            }
        }

        [Fact]
        public void ExecuteDataTable_Should_Return_Empty_DataTable_When_No_Rows()
        {
            using (var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;"))
            {
                connection.Open();
                using (var realCommand = connection.CreateCommand())
                {
                    realCommand.CommandText = "SELECT * FROM sys.databases WHERE 1=0";
                    var dt = ((SqlCommand)realCommand).ExecuteDataTable();

                    dt.ShouldNotBeNull();
                    dt.Rows.Count.ShouldBe(0);
                }
            }
        }

        [Fact]
        public void ExecuteDataTable_Should_Throw_On_Invalid_Sql()
        {
            using (var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;"))
            {
                connection.Open();
                using (var realCommand = connection.CreateCommand())
                {
                    realCommand.CommandText = "SELECT * FROM NonExistentTable";
                    Should.Throw<SqlException>(() => ((SqlCommand)realCommand).ExecuteDataTable());
                }
            }
        }
    }
}