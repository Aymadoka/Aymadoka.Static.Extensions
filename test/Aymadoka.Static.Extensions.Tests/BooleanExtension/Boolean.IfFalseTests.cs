namespace Aymadoka.Static.BooleanExtension
{
    public class Boolean_IfFalseTests
    {
        [Fact]
        public void IfFalse_BoolIsFalse_ActionIsInvoked()
        {
            // Arrange
            bool value = false;
            bool actionInvoked = false;

            // Act
            value.IfFalse(() => actionInvoked = true);

            // Assert
            Assert.True(actionInvoked);
        }

        [Fact]
        public void IfFalse_BoolIsTrue_ActionIsNotInvoked()
        {
            // Arrange
            bool value = true;
            bool actionInvoked = false;

            // Act
            value.IfFalse(() => actionInvoked = true);

            // Assert
            Assert.False(actionInvoked);
        }

        [Fact]
        public void IfFalse_NullAction_ThrowsArgumentNullException()
        {
            // Arrange
            bool value = false;
            Action action = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => value.IfFalse(action));
        }
    }
}
