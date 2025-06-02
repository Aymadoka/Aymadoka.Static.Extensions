using System;
using System.Data;
using Aymadoka.Static.DataExtension;
using NSubstitute;
using Shouldly;
using Xunit;

namespace Aymadoka.Static.Extensions.Tests.DataExtension
{
    public class IDataReader_ContainsColumnTests
    {
        [Fact]
        public void ContainsColumn_ByIndex_ReturnsTrue_WhenIndexExists()
        {
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(3);

            reader.ContainsColumn(0).ShouldBeTrue();
            reader.ContainsColumn(2).ShouldBeTrue();
        }

        [Fact]
        public void ContainsColumn_ByIndex_ReturnsFalse_WhenIndexNegative()
        {
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(3);

            reader.ContainsColumn(-1).ShouldBeFalse();
        }

        [Fact]
        public void ContainsColumn_ByIndex_ReturnsFalse_WhenIndexOutOfRange()
        {
            var reader = Substitute.For<IDataReader>();
            reader.FieldCount.Returns(2);

            reader.ContainsColumn(2).ShouldBeFalse();
            reader.ContainsColumn(100).ShouldBeFalse();
        }

        [Fact]
        public void ContainsColumn_ByIndex_ReturnsFalse_WhenFieldCountThrows()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => { var _ = x.FieldCount; }).Do(x => { throw new Exception(); });

            reader.ContainsColumn(0).ShouldBeFalse();
        }

        [Fact]
        public void ContainsColumn_ByName_ReturnsTrue_WhenColumnExists()
        {
            var reader = Substitute.For<IDataReader>();
            reader.GetOrdinal("Name").Returns(0);

            reader.ContainsColumn("Name").ShouldBeTrue();
        }

        [Fact]
        public void ContainsColumn_ByName_ReturnsFalse_WhenGetOrdinalThrows_AndIndexerThrows()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetOrdinal("NotExist")).Do(x => { throw new IndexOutOfRangeException(); });
            reader.When(x => { var _ = x["NotExist"]; }).Do(x => { throw new IndexOutOfRangeException(); });

            reader.ContainsColumn("NotExist").ShouldBeFalse();
        }

        [Fact]
        public void ContainsColumn_ByName_ReturnsTrue_WhenGetOrdinalThrows_ButIndexerReturnsNotNull()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetOrdinal("Other")).Do(x => { throw new Exception(); });
            reader["Other"].Returns(new object());

            reader.ContainsColumn("Other").ShouldBeTrue();
        }

        [Fact]
        public void ContainsColumn_ByName_ReturnsFalse_WhenGetOrdinalThrows_ButIndexerReturnsNull()
        {
            var reader = Substitute.For<IDataReader>();
            reader.When(x => x.GetOrdinal("NullColumn")).Do(x => { throw new Exception(); });
            reader["NullColumn"].Returns((object)null);

            reader.ContainsColumn("NullColumn").ShouldBeFalse();
        }
    }
}