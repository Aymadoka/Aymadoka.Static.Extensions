using NSubstitute;
using Shouldly;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteScalarAsTests
    {
        [Fact]
        public void ExecuteScalarAs_Should_Return_Correct_Value_For_Int()
        {
            var command = Substitute.For<DbCommand>();
            command.ExecuteScalar().Returns(123);

            var result = command.ExecuteScalarAs<int>();

            result.ShouldBe(123);
        }

        [Fact]
        public void ExecuteScalarAs_Should_Return_Correct_Value_For_String()
        {
            var command = Substitute.For<DbCommand>();
            command.ExecuteScalar().Returns("test");

            var result = command.ExecuteScalarAs<string>();

            result.ShouldBe("test");
        }

        [Fact]
        public void ExecuteScalarAs_Should_Throw_InvalidCastException_When_Type_Mismatch()
        {
            var command = Substitute.For<DbCommand>();
            command.ExecuteScalar().Returns("not an int");

            Should.Throw<InvalidCastException>(() =>
            {
                var _ = command.ExecuteScalarAs<int>();
            });
        }

        [Fact]
        public void ExecuteScalarAs_Should_Throw_InvalidCastException_When_Null()
        {
            var command = Substitute.For<DbCommand>();
            command.ExecuteScalar().Returns(null);

            Should.Throw<NullReferenceException>(() =>
            {
                var _ = command.ExecuteScalarAs<int>();
            });
        }

    }
}