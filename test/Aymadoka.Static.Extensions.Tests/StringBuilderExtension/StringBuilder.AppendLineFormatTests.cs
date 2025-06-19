using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public class StringBuilder_AppendLineFormatTests
    {
        [Fact]
        public void AppendLineFormat_WithParamsArgs_AppendsFormattedLine()
        {
            // Arrange
            var sb = new StringBuilder();
            string format = "Hello, {0}! You have {1} new messages.";
            object[] args = { "Alice", 5 };

            // Act
            sb.AppendLineFormat(format, args);

            // Assert
            string expected = "Hello, Alice! You have 5 new messages." + Environment.NewLine;
            Assert.Equal(expected, sb.ToString());
        }
    }
}
