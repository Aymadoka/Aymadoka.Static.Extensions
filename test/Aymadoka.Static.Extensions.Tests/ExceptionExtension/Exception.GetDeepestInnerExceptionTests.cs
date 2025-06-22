namespace Aymadoka.Static.ExceptionExtension
{
    public class Exception_GetDeepestInnerExceptionTests
    {
        [Fact]
        public void GetDeepestInnerException_ReturnsNull_WhenExceptionIsNull()
        {
            Exception? ex = null;
            var result = ex.GetDeepestInnerException();
            Assert.Null(result);
        }

        [Fact]
        public void GetDeepestInnerException_ReturnsSelf_WhenNoInnerException()
        {
            var ex = new Exception("root");
            var result = ex.GetDeepestInnerException();
            Assert.Same(ex, result);
        }

        [Fact]
        public void GetDeepestInnerException_ReturnsDeepestInnerException()
        {
            var innerMost = new Exception("innermost");
            var inner = new Exception("inner", innerMost);
            var outer = new Exception("outer", inner);

            var result = outer.GetDeepestInnerException();
            Assert.Same(innerMost, result);
        }

        [Fact]
        public void GetDeepestInnerException_ReturnsSecondLevelInnerException()
        {
            var inner = new Exception("inner");
            var outer = new Exception("outer", inner);

            var result = outer.GetDeepestInnerException();
            Assert.Same(inner, result);
        }
    }
}
