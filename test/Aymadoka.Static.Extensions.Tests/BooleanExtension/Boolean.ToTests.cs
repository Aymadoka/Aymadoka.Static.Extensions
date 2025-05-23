namespace Aymadoka.Static.BooleanExtension
{
    public class Boolean_ToTests
    {
        [Fact]
        public void To_BoolIsTrue_ReturnsTrueValue_Int()
        {
            // Arrange
            bool value = true;
            int trueValue = 1;
            int falseValue = 0;

            // Act
            var result = value.To(trueValue, falseValue);

            // Assert
            Assert.Equal(trueValue, result);
        }

        [Fact]
        public void To_BoolIsFalse_ReturnsFalseValue_Int()
        {
            // Arrange
            bool value = false;
            int trueValue = 1;
            int falseValue = 0;

            // Act
            var result = value.To(trueValue, falseValue);

            // Assert
            Assert.Equal(falseValue, result);
        }

        [Fact]
        public void To_BoolIsTrue_ReturnsTrueValue_String()
        {
            // Arrange
            bool value = true;
            string trueValue = "yes";
            string falseValue = "no";

            // Act
            var result = value.To(trueValue, falseValue);

            // Assert
            Assert.Equal(trueValue, result);
        }

        [Fact]
        public void To_BoolIsFalse_ReturnsFalseValue_String()
        {
            // Arrange
            bool value = false;
            string trueValue = "yes";
            string falseValue = "no";

            // Act
            var result = value.To(trueValue, falseValue);

            // Assert
            Assert.Equal(falseValue, result);
        }

        [Fact]
        public void To_BoolIsTrue_ReturnsTrueValue_ReferenceType()
        {
            // Arrange
            bool value = true;
            object trueValue = new object();
            object falseValue = new object();

            // Act
            var result = value.To(trueValue, falseValue);

            // Assert
            Assert.Same(trueValue, result);
        }

        [Fact]
        public void To_BoolIsFalse_ReturnsFalseValue_ReferenceType()
        {
            // Arrange
            bool value = false;
            object trueValue = new object();
            object falseValue = new object();

            // Act
            var result = value.To(trueValue, falseValue);

            // Assert
            Assert.Same(falseValue, result);
        }
    }
}
