namespace Aymadoka.Static.BooleanExtension
{
    public class Boolean_ToBinaryTests
    {
        [Fact]
        public void ToByte_BoolIsTrue_Returns1()
        {
            // Arrange
            bool value = true;

            // Act
            byte result = value.ToByte();

            // Assert
            Assert.Equal((byte)1, result);
        }

        [Fact]
        public void ToByte_BoolIsFalse_Returns0()
        {
            // Arrange
            bool value = false;

            // Act
            byte result = value.ToByte();

            // Assert
            Assert.Equal((byte)0, result);
        }
    }
}
