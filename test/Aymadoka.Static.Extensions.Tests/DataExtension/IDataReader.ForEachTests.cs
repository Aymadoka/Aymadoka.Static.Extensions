using NSubstitute;
using Shouldly;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public class IDataReader_ForEachTests
    {
        [Fact]
        public void ForEach_Should_Invoke_Action_For_Each_Row()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            // 模拟3行数据
            var callCount = 0;
            reader.Read().Returns(
                ci => callCount++ < 3 // 前3次返回true，之后返回false
            );

            var actionCallCount = 0;
            void Action(IDataReader r) => actionCallCount++;

            // Act
            var result = reader.ForEach(Action);

            // Assert
            actionCallCount.ShouldBe(3);
            result.ShouldBe(reader);
        }

        [Fact]
        public void ForEach_Should_Not_Invoke_Action_When_No_Rows()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();
            reader.Read().Returns(false);

            var actionCalled = false;
            void Action(IDataReader r) => actionCalled = true;

            // Act
            var result = reader.ForEach(Action);

            // Assert
            actionCalled.ShouldBeFalse();
            result.ShouldBe(reader);
        }

        [Fact]
        public void ForEach_Should_Throw_If_Action_Is_Null()
        {
            // Arrange
            var reader = Substitute.For<IDataReader>();

            // Act & Assert
            Should.Throw<ArgumentNullException>(() => reader.ForEach(null));
        }
    }
}