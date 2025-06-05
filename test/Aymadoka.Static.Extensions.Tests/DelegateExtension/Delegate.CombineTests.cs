namespace Aymadoka.Static.DelegateExtension
{
    public class Delegate_CombineTests
    {
        [Fact]
        public void Combine_TwoActionDelegates_BothAreInvoked()
        {
            // Arrange
            bool firstInvoked = false;
            bool secondInvoked = false;
            Action first = () => firstInvoked = true;
            Action second = () => secondInvoked = true;

            // Act
            var combined = first.Combine(second) as Action;
            combined?.Invoke();

            // Assert
            Assert.True(firstInvoked);
            Assert.True(secondInvoked);
        }

        [Fact]
        public void Combine_NullFirstDelegate_ReturnsSecond()
        {
            // Arrange
            Action first = null;
            Action second = () => { };

            // Act
            var combined = first.Combine(second);

            // Assert
            Assert.Equal(second, combined);
        }

        [Fact]
        public void Combine_NullSecondDelegate_ReturnsFirst()
        {
            // Arrange
            Action first = () => { };
            Action second = null;

            // Act
            var combined = first.Combine(second);

            // Assert
            Assert.Equal(first, combined);
        }

        [Fact]
        public void Combine_BothNull_ReturnsNull()
        {
            // Arrange
            Action first = null;
            Action second = null;

            // Act
            var combined = first.Combine(second);

            // Assert
            Assert.Null(combined);
        }
    }
}
