namespace Aymadoka.Static.BooleanExtension
{
    public class Boolean_IfTrueTests
    {
        [Fact]
        public void IfTrue_BoolIsTrue_ActionIsInvoked()
        {
            // Arrange
            bool value = true;
            bool actionInvoked = false;

            // Act
            value.IfTrue(() => actionInvoked = true);

            // Assert
            Assert.True(actionInvoked);
        }

        [Fact]
        public void IfTrue_BoolIsFalse_ActionIsNotInvoked()
        {
            // Arrange
            bool value = false;
            bool actionInvoked = false;

            // Act
            value.IfTrue(() => actionInvoked = true);

            // Assert
            Assert.False(actionInvoked);
        }

        [Fact]
        public void IfTrue_NullAction_ThrowsArgumentNullException()
        {
            // Arrange
            bool value = true;
            Action action = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => value.IfTrue(action));
        }
    }
}
