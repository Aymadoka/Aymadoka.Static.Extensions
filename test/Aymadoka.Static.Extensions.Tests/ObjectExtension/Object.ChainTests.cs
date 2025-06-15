namespace Aymadoka.Static.ObjectExtension
{
    public class Object_ChainTests
    {
        [Fact]
        public void Chain_ActionIsCalled_ObjectIsReturned()
        {
            // Arrange
            var obj = new TestClass { Value = 1 };
            bool actionCalled = false;

            // Act
            var result = obj.Chain(o =>
            {
                o.Value = 2;
                actionCalled = true;
            });

            // Assert
            Assert.True(actionCalled);
            Assert.Equal(2, obj.Value);
            Assert.Same(obj, result);
        }

        private class TestClass
        {
            public int Value { get; set; }
        }
    }
}
