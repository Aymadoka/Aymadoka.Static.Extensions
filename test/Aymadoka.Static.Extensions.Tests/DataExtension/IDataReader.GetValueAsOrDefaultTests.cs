using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public class IDataReader_GetValueAsOrDefaultTests
    {
        [Fact]
        public void GetValueAsOrDefault_ByIndex_ReturnsValue_WhenNoException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.GetValue(1).Returns("test");

            var result = reader.GetValueAsOrDefault<string>(1);

            result.ShouldBe("test");
        }

        [Fact]
        public void GetValueAsOrDefault_ByIndex_ReturnsDefault_WhenException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetValue(2)).Do(x => { throw new IndexOutOfRangeException(); });

            var result = reader.GetValueAsOrDefault<int>(2);

            result.ShouldBe(default(int));
        }

        [Fact]
        public void GetValueAsOrDefault_ByIndex_ReturnsDefaultValue_WhenException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetValue(3)).Do(x => { throw new Exception(); });

            var result = reader.GetValueAsOrDefault(3, 42);

            result.ShouldBe(42);
        }

        [Fact]
        public void GetValueAsOrDefault_ByIndex_ReturnsFactoryValue_WhenException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetValue(4)).Do(x => { throw new Exception(); });

            var result = reader.GetValueAsOrDefault(4, (r, i) => $"default-{i}");

            result.ShouldBe("default-4");
        }

        [Fact]
        public void GetValueAsOrDefault_ByColumnName_ReturnsValue_WhenNoException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.GetOrdinal("Name").Returns(0);
            reader.GetValue(0).Returns("Alice");

            var result = reader.GetValueAsOrDefault<string>("Name");

            result.ShouldBe("Alice");
        }

        [Fact]
        public void GetValueAsOrDefault_ByColumnName_ReturnsDefault_WhenException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetOrdinal("Age")).Do(x => { throw new IndexOutOfRangeException(); });

            var result = reader.GetValueAsOrDefault<int>("Age");

            result.ShouldBe(default(int));
        }

        [Fact]
        public void GetValueAsOrDefault_ByColumnName_ReturnsDefaultValue_WhenException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetOrdinal("Score")).Do(x => { throw new Exception(); });

            var result = reader.GetValueAsOrDefault("Score", 99);

            result.ShouldBe(99);
        }

        [Fact]
        public void GetValueAsOrDefault_ByColumnName_ReturnsFactoryValue_WhenException()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetOrdinal("Status")).Do(x => { throw new Exception(); });

            var result = reader.GetValueAsOrDefault("Status", (r, c) => $"default-{c}");

            result.ShouldBe("default-Status");
        }
    }
}