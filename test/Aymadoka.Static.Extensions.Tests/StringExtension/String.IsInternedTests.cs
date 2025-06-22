namespace Aymadoka.Static.StringExtension
{
    public class String_IsInternedTests
    {
        [Fact]
        public void IsInterned_ReturnsReference_ForInternedString()
        {
            // Arrange
            string s1 = "hello";
            string s2 = string.Copy(s1);
            string interned = string.Intern(s2);

            // Act
            string? result = s2.IsInterned();

            // Assert
            Assert.Same(interned, result);
        }

        [Fact]
        public void IsInterned_ReturnsNull_ForNonInternedString()
        {
            // Arrange
            string s = new string("not_interned".ToCharArray());

            // Act
            string? result = s.IsInterned();

            // Assert
            Assert.Equal(result, "not_interned");
        }

        [Fact]
        public void IsInterned_ReturnsReference_ForLiteralString()
        {
            // Arrange
            string s = "literal_string";

            // Act
            string? result = s.IsInterned();

            // Assert
            Assert.Same(s, result);
        }
    }
}
