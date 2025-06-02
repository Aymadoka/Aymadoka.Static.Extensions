using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class IDataReader_GetValueToOrDefault_Tests
    {
        private readonly IDataReader _reader;

        public IDataReader_GetValueToOrDefault_Tests()
        {
            _reader = Substitute.For<IDataReader>();
        }

        [Fact]
        public void GetValueToOrDefault_ByIndex_Returns_Converted_Value()
        {
            _reader.GetValue(0).Returns("123");
            var result = _reader.GetValueToOrDefault<int>(0);
            result.ShouldBe(123);
        }

        [Fact]
        public void GetValueToOrDefault_ByIndex_Returns_Default_On_Exception()
        {
            _reader.GetValue(0).Returns(x => { throw new Exception(); });
            var result = _reader.GetValueToOrDefault<int>(0);
            result.ShouldBe(0);
        }

        [Fact]
        public void GetValueToOrDefault_ByIndex_WithDefaultValue_Returns_Converted_Value()
        {
            _reader.GetValue(1).Returns("true");
            var result = _reader.GetValueToOrDefault<bool>(1, false);
            result.ShouldBeTrue();
        }

        [Fact]
        public void GetValueToOrDefault_ByIndex_WithDefaultValue_Returns_Default_On_Exception()
        {
            _reader.GetValue(1).Returns(x => { throw new Exception(); });
            var result = _reader.GetValueToOrDefault<bool>(1, true);
            result.ShouldBeTrue();
        }

        [Fact]
        public void GetValueToOrDefault_ByIndex_WithFactory_Returns_Converted_Value()
        {
            _reader.GetValue(2).Returns("42");
            var result = _reader.GetValueToOrDefault<int>(2, (r, i) => -1);
            result.ShouldBe(42);
        }

        [Fact]
        public void GetValueToOrDefault_ByIndex_WithFactory_Returns_Factory_On_Exception()
        {
            _reader.GetValue(2).Returns(x => { throw new Exception(); });
            var result = _reader.GetValueToOrDefault<int>(2, (r, i) => -1);
            result.ShouldBe(-1);
        }

        [Fact]
        public void GetValueToOrDefault_ByColumnName_Returns_Converted_Value()
        {
            _reader.GetOrdinal("Age").Returns(3);
            _reader.GetValue(3).Returns("18");
            var result = _reader.GetValueToOrDefault<int>("Age");
            result.ShouldBe(18);
        }

        [Fact]
        public void GetValueToOrDefault_ByColumnName_Returns_Default_On_Exception()
        {
            _reader.GetOrdinal("Age").Returns(x => { throw new Exception(); });
            var result = _reader.GetValueToOrDefault<int>("Age");
            result.ShouldBe(0);
        }

        [Fact]
        public void GetValueToOrDefault_ByColumnName_WithDefaultValue_Returns_Converted_Value()
        {
            _reader.GetOrdinal("Name").Returns(4);
            _reader.GetValue(4).Returns("Tom");
            var result = _reader.GetValueToOrDefault<string>("Name", "Default");
            result.ShouldBe("Tom");
        }

        [Fact]
        public void GetValueToOrDefault_ByColumnName_WithDefaultValue_Returns_Default_On_Exception()
        {
            _reader.GetOrdinal("Name").Returns(4);
            _reader.GetValue(4).Returns(x => { throw new Exception(); });
            var result = _reader.GetValueToOrDefault<string>("Name", "Default");
            result.ShouldBe("Default");
        }

        [Fact]
        public void GetValueToOrDefault_ByColumnName_WithFactory_Returns_Converted_Value()
        {
            _reader.GetOrdinal("Score").Returns(5);
            _reader.GetValue(5).Returns("99.5");
            var result = _reader.GetValueToOrDefault<double>("Score", (r, c) => -1.0);
            result.ShouldBe(99.5);
        }

        [Fact]
        public void GetValueToOrDefault_ByColumnName_WithFactory_Returns_Factory_On_Exception()
        {
            _reader.GetOrdinal("Score").Returns(5);
            _reader.GetValue(5).Returns(x => { throw new Exception(); });
            var result = _reader.GetValueToOrDefault<double>("Score", (r, c) => -1.0);
            result.ShouldBe(-1.0);
        }
    }
}
