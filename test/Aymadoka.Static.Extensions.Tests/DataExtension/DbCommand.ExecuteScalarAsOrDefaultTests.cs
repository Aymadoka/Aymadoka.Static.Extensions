using NSubstitute;
using Shouldly;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteScalarAsOrDefaultTests
    {
        [Fact]
        public void ExecuteScalarAsOrDefault_ReturnsConvertedValue()
        {
            var cmd = Substitute.For<DbCommand>();
            cmd.ExecuteScalar().Returns(42);

            var result = cmd.ExecuteScalarAsOrDefault<int>();

            result.ShouldBe(42);
        }

        [Fact]
        public void ExecuteScalarAsOrDefault_ReturnsDefaultOnException()
        {
            var cmd = Substitute.For<DbCommand>();
            cmd.When(x => x.ExecuteScalar()).Do(_ => throw new InvalidOperationException());

            var result = cmd.ExecuteScalarAsOrDefault<int>();

            result.ShouldBe(default(int));
        }

        [Fact]
        public void ExecuteScalarAsOrDefault_WithDefaultValue_ReturnsConvertedValue()
        {
            var cmd = Substitute.For<DbCommand>();
            cmd.ExecuteScalar().Returns("abc");

            var result = cmd.ExecuteScalarAsOrDefault<string>("default");

            result.ShouldBe("abc");
        }

        [Fact]
        public void ExecuteScalarAsOrDefault_WithDefaultValue_ReturnsDefaultOnException()
        {
            var cmd = Substitute.For<DbCommand>();
            cmd.When(x => x.ExecuteScalar()).Do(_ => throw new Exception());

            var result = cmd.ExecuteScalarAsOrDefault<string>("default");

            result.ShouldBe("default");
        }

        [Fact]
        public void ExecuteScalarAsOrDefault_WithFactory_ReturnsConvertedValue()
        {
            var cmd = Substitute.For<DbCommand>();
            cmd.ExecuteScalar().Returns(100);

            var result = cmd.ExecuteScalarAsOrDefault(c => 999);

            result.ShouldBe(100);
        }

        [Fact]
        public void ExecuteScalarAsOrDefault_WithFactory_ReturnsFactoryValueOnException()
        {
            var cmd = Substitute.For<DbCommand>();
            cmd.When(x => x.ExecuteScalar()).Do(_ => throw new Exception());

            var result = cmd.ExecuteScalarAsOrDefault(c => 999);

            result.ShouldBe(999);
        }
    }
}