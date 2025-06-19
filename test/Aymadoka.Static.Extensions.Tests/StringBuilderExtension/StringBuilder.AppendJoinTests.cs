using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public class StringBuilder_AppendJoinTests
    {
        [Fact]
        public void AppendJoin_WithIEnumerable_AppendsJoinedString()
        {
            // Arrange
            var sb = new StringBuilder("Start:");
            var values = new List<int> { 1, 2, 3 };

            // Act
            sb.AppendJoin(",", values);

            // Assert
            Assert.Equal("Start:1,2,3", sb.ToString());
        }

        [Fact]
        public void AppendJoin_WithArray_AppendsJoinedString()
        {
            // Arrange
            var sb = new StringBuilder();
            var values = new[] { "a", "b", "c" };

            // Act
            sb.AppendJoin("-", values);

            // Assert
            Assert.Equal("a-b-c", sb.ToString());
        }

        [Fact]
        public void AppendJoin_WithEmptyIEnumerable_AppendsNothing()
        {
            // Arrange
            var sb = new StringBuilder("X");
            var values = new List<string>();

            // Act
            sb.AppendJoin(",", values);

            // Assert
            Assert.Equal("X", sb.ToString());
        }

        [Fact]
        public void AppendJoin_WithEmptyArray_AppendsNothing()
        {
            // Arrange
            var sb = new StringBuilder("Y");

            // Act
            sb.AppendJoin(";", new int[0]);

            // Assert
            Assert.Equal("Y", sb.ToString());
        }

        [Fact]
        public void AppendJoin_WithNullSeparator_TreatsAsEmpty()
        {
            // Arrange
            var sb = new StringBuilder();
            var values = new[] { "x", "y" };

            // Act
            sb.AppendJoin(null, values);

            // Assert
            Assert.Equal("xy", sb.ToString());
        }
    }
}
