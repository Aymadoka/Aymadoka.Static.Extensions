using Microsoft.Data.SqlClient;
using NSubstitute;
using Shouldly;
using System.Reflection;

namespace Aymadoka.Static.DataExtension
{

    public class SqlBulkCopy_GetTransactionTests
    {
        [Fact]
        public void GetTransaction_Should_Return_Transaction_When_Exists()
        {
            // Arrange
            var sqlBulkCopy = Substitute.For<SqlBulkCopy>("connectionString");
            var transaction = Substitute.For<SqlTransaction>();
            var field = typeof(SqlBulkCopy).GetField("_externalTransaction", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(sqlBulkCopy, transaction);

            // Act
            var result = sqlBulkCopy.GetTransaction();

            // Assert
            result.ShouldBe(transaction);
        }

        [Fact]
        public void GetTransaction_Should_Return_Null_When_Transaction_Not_Exists()
        {
            // Arrange
            var sqlBulkCopy = Substitute.For<SqlBulkCopy>("connectionString");
            var field = typeof(SqlBulkCopy).GetField("_externalTransaction", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(sqlBulkCopy, null);

            // Act
            var result = sqlBulkCopy.GetTransaction();

            // Assert
            result.ShouldBeNull();
        }
    }
}