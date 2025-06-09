namespace Aymadoka.Static.EnumExtension
{
    public class Enum_IsDefinedTests
    {
        private enum TestEnum
        {
            Value1 = 0,
            Value2 = 1
        }

        [Fact]
        public void IsDefined_ReturnsTrue_ForDefinedValue()
        {
            // Arrange
            TestEnum value = TestEnum.Value1;

            // Act
            bool result = value.IsDefined();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDefined_ReturnsFalse_ForUndefinedValue()
        {
            // Arrange
            TestEnum value = (TestEnum)999;

            // Act
            bool result = value.IsDefined();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsDefined_ReturnsTrue_ForLastDefinedValue()
        {
            // Arrange
            TestEnum value = TestEnum.Value2;

            // Act
            bool result = value.IsDefined();

            // Assert
            Assert.True(result);
        }
    }
}
