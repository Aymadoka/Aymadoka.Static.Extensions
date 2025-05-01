namespace Aymadoka.Static.ExceptionExtension
{
    public class ExceptionExtensionsTests
    {
        [Fact] 
        public void InnerException_ShouldReturnNull_WhenExceptionIsNull()
        {
            // Arrange
            Exception? exception = null;

            // Act
            var result = exception.GetDeepestInnerException();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void InnerException_ShouldReturnSameException_WhenNoInnerExceptionExists()
        {
            // Arrange
            var exception = new Exception("Outer exception");

            // Act
            var result = exception.GetDeepestInnerException();

            // Assert
            Assert.Equal(exception, result);
        }

        [Fact]
        public void InnerException_ShouldReturnDeepestInnerException_WhenInnerExceptionsExist()
        {
            // Arrange
            var innerMostException = new Exception("Innermost exception");
            var middleException = new Exception("Middle exception", innerMostException);
            var outerException = new Exception("Outer exception", middleException);

            // Act
            var result = outerException.GetDeepestInnerException();

            // Assert
            Assert.Equal(innerMostException, result);
        }
    }
}
