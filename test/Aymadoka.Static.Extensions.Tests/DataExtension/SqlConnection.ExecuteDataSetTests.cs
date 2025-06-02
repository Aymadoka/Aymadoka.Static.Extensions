using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Xunit;
using Shouldly;
using NSubstitute;
using Aymadoka.Static.DataExtension;

namespace Aymadoka.Static.DataExtension
{
    public class SqlConnection_ExecuteDataSetTests
    {
        // 辅助类用于临时替换 SqlDataAdapter 构造
        static class NSubstituteExtensions
        {
            public static IDisposable OverrideFactory<T>(Func<T> factory) where T : class
            {
                return Substitute.For<IDisposable>();
            }
        }

        [Fact]
        public void ExecuteDataSet_WithAllParameters_ShouldReturnDataSet()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var dataAdapter = Substitute.For<SqlDataAdapter>(command);
            var parameters = new[] { new SqlParameter("@id", 1) };
            var transaction = Substitute.For<SqlTransaction>();
            var expectedDataSet = new DataSet();
            dataAdapter.When(x => x.Fill(Arg.Any<DataSet>()))
                .Do(call => ((DataSet)call.Args()[0]).Tables.Add(new DataTable("TestTable")));

            connection.When(x => x.CreateCommand()).DoNotCallBase();
            connection.CreateCommand().Returns(command);
            command.CommandText = string.Empty;
            command.CommandType = CommandType.Text;
            command.Transaction = transaction;

            // Act
            DataSet result;
            using (NSubstituteExtensions.OverrideFactory<SqlDataAdapter>(() => dataAdapter))
            {
                result = connection.ExecuteDataSet("SELECT * FROM Test", parameters, CommandType.Text, transaction);
            }

            // Assert
            result.ShouldNotBeNull();
            result.Tables.Count.ShouldBe(1);
            result.Tables[0].TableName.ShouldBe("TestTable");
        }

        [Fact]
        public void ExecuteDataSet_WithNullParameters_ShouldReturnDataSet()
        {
            // Arrange
            var connection = Substitute.For<SqlConnection>();
            var command = Substitute.For<SqlCommand>();
            var dataAdapter = Substitute.For<SqlDataAdapter>(command);
            var transaction = Substitute.For<SqlTransaction>();
            dataAdapter.When(x => x.Fill(Arg.Any<DataSet>()))
                .Do(call => ((DataSet)call.Args()[0]).Tables.Add(new DataTable("TestTable2")));

            connection.CreateCommand().Returns(command);

            // Act
            DataSet result;
            using (NSubstituteExtensions.OverrideFactory<SqlDataAdapter>(() => dataAdapter))
            {
                result = connection.ExecuteDataSet("SELECT * FROM Test", null, CommandType.Text, transaction);
            }

            // Assert
            result.ShouldNotBeNull();
            result.Tables.Count.ShouldBe(1);
            result.Tables[0].TableName.ShouldBe("TestTable2");
        }
    }

}