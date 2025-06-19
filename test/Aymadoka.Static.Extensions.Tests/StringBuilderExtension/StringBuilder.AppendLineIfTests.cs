using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public class StringBuilder_AppendLineIfTests
    {
        [Fact]
        public void AppendLineIf_AppendsMatchingValues()
        {
            // Arrange
            var sb = new StringBuilder();
            int[] values = { 1, 2, 3, 4, 5 };

            // Act
            sb.AppendLineIf(x => x % 2 == 0, values);

            // Assert
            var expected = "2" + Environment.NewLine + "4" + Environment.NewLine;
            Assert.Equal(expected, sb.ToString());
        }

        [Fact]
        public void AppendLineIf_NoValuesMatch_DoesNotAppend()
        {
            // Arrange
            var sb = new StringBuilder();
            string[] values = { "a", "b", "c" };

            // Act
            sb.AppendLineIf(s => s == "z", values);

            // Assert
            Assert.Equal(string.Empty, sb.ToString());
        }

        [Fact]
        public void AppendLineIf_AllValuesMatch_AppendsAll()
        {
            // Arrange
            var sb = new StringBuilder();
            var values = new[] { "x", "y" };

            // Act
            sb.AppendLineIf(s => true, values);

            // Assert
            var expected = "x" + Environment.NewLine + "y" + Environment.NewLine;
            Assert.Equal(expected, sb.ToString());
        }

        [Fact]
        public void AppendLineIf_HandlesNullValues()
        {
            // Arrange
            var sb = new StringBuilder();
            string[] values = { null, "a" };

            // Act
            sb.AppendLineIf(s => s == null, values);

            // Assert
            var expected = string.Empty + Environment.NewLine;
            Assert.Equal(expected, sb.ToString());
        }
    }
}
