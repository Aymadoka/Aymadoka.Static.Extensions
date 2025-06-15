using System.Reflection;

namespace Aymadoka.Static.AssemblyExtension
{
    public class Assembly_GetAttributeTests
    {
        [AttributeUsage(AttributeTargets.Assembly)]
        private class TestAssemblyAttribute : Attribute
        {
            public string Name { get; set; }
        }

        [Fact]
        public void GetAttribute_ReturnsAttribute_WhenAttributeExists()
        {
            // Arrange
            var assembly = typeof(Assembly_GetAttributeTests).Assembly;

            // Act
            var attribute = assembly.GetAttribute<AssemblyTitleAttribute>();

            // Assert
            Assert.NotNull(attribute);
            Assert.IsType<AssemblyTitleAttribute>(attribute);
        }

        [Fact]
        public void GetAttribute_ReturnsNull_WhenAttributeDoesNotExist()
        {
            // Arrange
            var assembly = typeof(Assembly_GetAttributeTests).Assembly;

            // Act
            var attribute = assembly.GetAttribute<TestAssemblyAttribute>();

            // Assert
            Assert.Null(attribute);
        }
    }
}
