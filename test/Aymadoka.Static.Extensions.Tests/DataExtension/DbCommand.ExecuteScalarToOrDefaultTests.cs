using NSubstitute;
using Shouldly;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteScalarToOrDefaultTests
    {
        [Fact]
        public void ExecuteScalarToOrDefault_Returns_Converted_Value()
        {
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.ExecuteScalar().Returns(123);

            var result = dbCommand.ExecuteScalarToOrDefault<int>();

            result.ShouldBe(123);
        }

        [Fact]
        public void ExecuteScalarToOrDefault_Returns_Default_On_Exception()
        {
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.When(x => x.ExecuteScalar()).Do(x => throw new Exception());

            var result = dbCommand.ExecuteScalarToOrDefault<int>();

            result.ShouldBe(0);
        }

        [Fact]
        public void ExecuteScalarToOrDefault_With_DefaultValue_Returns_Converted_Value()
        {
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.ExecuteScalar().Returns("true");

            var result = dbCommand.ExecuteScalarToOrDefault<bool>(false);

            result.ShouldBe(true);
        }

        [Fact]
        public void ExecuteScalarToOrDefault_With_DefaultValue_Returns_Default_On_Exception()
        {
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.When(x => x.ExecuteScalar()).Do(x => throw new Exception());

            var result = dbCommand.ExecuteScalarToOrDefault("default");

            result.ShouldBe("default");
        }

        [Fact]
        public void ExecuteScalarToOrDefault_With_Factory_Returns_Converted_Value()
        {
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.ExecuteScalar().Returns(42);

            var result = dbCommand.ExecuteScalarToOrDefault(db => db.CommandText.Length);

            result.ShouldBe(42);
        }

        [Fact]
        public void ExecuteScalarToOrDefault_With_Factory_Returns_Factory_Value_On_Exception()
        {
            var dbCommand = Substitute.For<DbCommand>();
            dbCommand.CommandText = "SELECT 1";
            dbCommand.When(x => x.ExecuteScalar()).Do(x => throw new Exception());

            var result = dbCommand.ExecuteScalarToOrDefault(db => db.CommandText.Length);

            result.ShouldBe(8);
        }
    }
}