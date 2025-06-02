using Microsoft.Data.SqlClient;
using NSubstitute;
using Shouldly;
using System.Reflection;
using System.Runtime.Serialization;

namespace Aymadoka.Static.DataExtension
{

    public class SqlBulkCopy_GetConnectionTests
    {
        [Fact]
        public void GetConnection_Should_Return_Private_SqlConnection_Instance()
        {
            // Arrange
            var sqlConnection = Substitute.For<SqlConnection>();
            var sqlBulkCopy = FormatterServices.GetUninitializedObject(typeof(SqlBulkCopy)) as SqlBulkCopy;
            var field = typeof(SqlBulkCopy).GetField("_connection", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(sqlBulkCopy, sqlConnection);

            // Act
            var result = sqlBulkCopy.GetConnection();

            // Assert
            result.ShouldBe(sqlConnection);
        }

        [Fact]
        public void GetConnection_Should_Return_Null_If_Field_Is_Null()
        {
            // Arrange
            var sqlBulkCopy = FormatterServices.GetUninitializedObject(typeof(SqlBulkCopy)) as SqlBulkCopy;
            var field = typeof(SqlBulkCopy).GetField("_connection", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(sqlBulkCopy, null);

            // Act
            var result = sqlBulkCopy.GetConnection();

            // Assert
            result.ShouldBeNull();
        }
    }
}