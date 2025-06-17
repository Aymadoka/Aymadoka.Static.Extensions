namespace Aymadoka.Static.StringExtension
{
    public class String_InternTests
    {
        [Fact]
        public void Intern_ReturnsSameReference_ForEqualStrings()
        {
            // Arrange
            string str1 = new string("hello".ToCharArray());
            string str2 = new string("hello".ToCharArray());

            // Act
            string interned1 = str1.Intern();
            string interned2 = str2.Intern();

            // Assert
            Assert.True(object.ReferenceEquals(interned1, interned2));
        }

        [Fact]
        public void Intern_ReturnsReference_ForLiteral()
        {
            // Arrange
            string literal = "world";
            string str = new string("world".ToCharArray());

            // Act
            string interned = str.Intern();

            // Assert
            Assert.True(object.ReferenceEquals(literal, interned));
        }

        [Fact]
        public void Intern_Null_ThrowsArgumentNullException()
        {
            // Arrange
            string str = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => str.Intern());
        }
    }
}
