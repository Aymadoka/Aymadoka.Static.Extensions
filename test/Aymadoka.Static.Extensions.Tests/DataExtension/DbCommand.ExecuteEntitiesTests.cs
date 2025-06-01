using NSubstitute;
using Shouldly;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public class DbCommand_ExecuteEntitiesTests
    {
        public class TestEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void ExecuteEntities_Should_Return_Entities_From_Reader()
        {
            // Arrange
            var dbCommand = Substitute.For<DbCommand>();
            var dataReader = Substitute.For<IDataReader>();

            // 模拟IDataReader行为
            var readCount = 0;
            dataReader.Read().Returns(_ => readCount++ == 0, _ => false);
            dataReader.FieldCount.Returns(2);
            dataReader.GetName(0).Returns("Id");
            dataReader.GetName(1).Returns("Name");
            dataReader["Id"].Returns(1);
            dataReader["Name"].Returns("TestName");

            dbCommand.ExecuteReader().Returns(dataReader);

            // 模拟ToEntities扩展方法
            // 这里假设ToEntities<T>已实现并可用
            // 若ToEntities<T>未实现，则需Mock或Stub

            // Act
            var result = dbCommand.ExecuteEntities<TestEntity>();

            // Assert
            result.ShouldNotBeNull();
            var list = new List<TestEntity>(result);
            list.Count.ShouldBe(1);
            list[0].Id.ShouldBe(1);
            list[0].Name.ShouldBe("TestName");
        }
    }
}