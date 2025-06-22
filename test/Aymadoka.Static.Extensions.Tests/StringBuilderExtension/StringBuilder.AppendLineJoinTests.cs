using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public class StringBuilder_AppendLineJoinTests
    {
        [Fact]
        public void AppendLineJoin_WithIEnumerable_AddsJoinedStringAndNewLine()
        {
            // Arrange
            var sb = new StringBuilder();
            var values = new List<string> { "A", "B", "C" };

            // Act
            sb.AppendLineJoin(",", values);

            // Assert
            Assert.Equal("A,B,C" + System.Environment.NewLine, sb.ToString());
        }

        [Fact]
        public void AppendLineJoin_WithEmptyIEnumerable_AddsOnlyNewLine()
        {
            // Arrange
            var sb = new StringBuilder();
            var values = new List<string>();

            // Act
            sb.AppendLineJoin(",", values);

            // Assert
            Assert.Equal(System.Environment.NewLine, sb.ToString());
        }

        [Fact]
        public void AppendLineJoin_WithParams_AddsJoinedStringAndNewLine()
        {
            // Arrange
            var sb = new StringBuilder();

            // Act
            sb.AppendLineJoin(":", 1, 2, 3);

            // Assert
            Assert.Equal("1:2:3" + System.Environment.NewLine, sb.ToString());
        }

        [Fact]
        public void AppendLineJoin_WithEmptyParams_AddsOnlyNewLine()
        {
            // Arrange
            var sb = new StringBuilder();

            // Act
            sb.AppendLineJoin(";", new object[0]);

            // Assert
            Assert.Equal(System.Environment.NewLine, sb.ToString());
        }       
    }
}
