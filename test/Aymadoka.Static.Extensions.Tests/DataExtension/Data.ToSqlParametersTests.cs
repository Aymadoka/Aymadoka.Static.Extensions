using Microsoft.Data.SqlClient;

namespace Aymadoka.Static.DataExtension
{
    public class Data_ToSqlParametersTests
    {
        [Fact]
        public void ToSqlParameters_WithValidDictionary_ReturnsSqlParameters()
        {
            // Arrange
            var dict = new Dictionary<string, object>
            {
                { "@Id", 1 },
                { "@Name", "Test" },
                { "@IsActive", true }
            };

            // Act
            SqlParameter[] parameters = dict.ToSqlParameters();

            // Assert
            Assert.Equal(3, parameters.Length);
            Assert.Contains(parameters, p => p.ParameterName == "@Id" && (int)p.Value == 1);
            Assert.Contains(parameters, p => p.ParameterName == "@Name" && (string)p.Value == "Test");
            Assert.Contains(parameters, p => p.ParameterName == "@IsActive" && (bool)p.Value == true);
        }

        [Fact]
        public void ToSqlParameters_WithEmptyDictionary_ReturnsEmptyArray()
        {
            // Arrange
            var dict = new Dictionary<string, object>();

            // Act
            SqlParameter[] parameters = dict.ToSqlParameters();

            // Assert
            Assert.NotNull(parameters);
            Assert.Empty(parameters);
        }

        [Fact]
        public void ToSqlParameters_WithNullValue_ParameterValueIsDBNull()
        {
            // Arrange
            var dict = new Dictionary<string, object>
            {
                { "@Nullable", null }
            };

            // Act
            SqlParameter[] parameters = dict.ToSqlParameters();

            // Assert
            Assert.Single(parameters);
            Assert.Equal("@Nullable", parameters[0].ParameterName);
            Assert.Null(parameters[0].Value);
        }
    }
}
