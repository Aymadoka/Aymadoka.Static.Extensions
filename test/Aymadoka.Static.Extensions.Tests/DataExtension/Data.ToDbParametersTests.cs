using System.Data.Common;
using NSubstitute;
using Shouldly;

namespace Aymadoka.Static.DataExtension
{
    public class DataExtensions_ToDbParameters_Tests
    {
        [Fact]
        public void ToDbParameters_WithDbCommand_ShouldReturnParameters()
        {
            // Arrange
            var dict = new Dictionary<string, object>
            {
                { "Id", 1 },
                { "Name", "Test" }
            };

            var command = Substitute.For<DbCommand>();
            var parameters = new List<DbParameter>();

            command.CreateParameter().Returns(ci =>
            {
                var param = Substitute.For<DbParameter>();
                parameters.Add(param);
                return param;
            });

            // Act
            var result = dict.ToDbParameters(command);

            // Assert
            result.Length.ShouldBe(2);
            result[0].ParameterName.ShouldBe("Id");
            result[0].Value.ShouldBe(1);
            result[1].ParameterName.ShouldBe("Name");
            result[1].Value.ShouldBe("Test");
        }

        [Fact]
        public void ToDbParameters_WithDbConnection_ShouldReturnParameters()
        {
            // Arrange
            var dict = new Dictionary<string, object>
            {
                { "Age", 30 },
                { "City", "Shanghai" }
            };

            var command = Substitute.For<DbCommand>();
            var connection = Substitute.For<DbConnection>();
            var parameters = new List<DbParameter>();

            connection.CreateCommand().Returns(command);

            command.CreateParameter().Returns(ci =>
            {
                var param = Substitute.For<DbParameter>();
                parameters.Add(param);
                return param;
            });

            // Act
            var result = dict.ToDbParameters(connection);

            // Assert
            result.Length.ShouldBe(2);
            result[0].ParameterName.ShouldBe("Age");
            result[0].Value.ShouldBe(30);
            result[1].ParameterName.ShouldBe("City");
            result[1].Value.ShouldBe("Shanghai");
        }
    }
}