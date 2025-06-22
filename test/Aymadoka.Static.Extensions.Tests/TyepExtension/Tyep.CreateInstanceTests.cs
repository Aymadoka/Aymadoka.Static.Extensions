using System.Globalization;
using System.Reflection;

namespace Aymadoka.Static.TyepExtension
{
    public class Tyep_CreateInstanceTests
    {
        private class TestClass
        {
            public int Value { get; }
            public string Text { get; }
            public static string StaticValue = "Static";

            public TestClass()
            {
                Value = 42;
                Text = "default";
            }

            public TestClass(int value, string text)
            {
                Value = value;
                Text = text;
            }

            private TestClass(string text)
            {
                Value = -1;
                Text = text;
            }
        }

        [Fact]
        public void CreateInstance_WithBindingFlagsBinderArgsCultureActivationAttributes_ReturnsInstance()
        {
            // Arrange
            Type type = typeof(TestClass);
            BindingFlags bindingAttr = BindingFlags.Public | BindingFlags.Instance;
            Binder binder = Type.DefaultBinder;
            object[] args = new object[] { 42, "hello" };
            CultureInfo culture = CultureInfo.InvariantCulture;
            object[] activationAttributes = new object[0];

            // Act
            var instance = type.CreateInstance<TestClass>(bindingAttr, binder, args, culture, activationAttributes);

            // Assert
            Assert.NotNull(instance);
            Assert.Equal(42, instance.Value);
            Assert.Equal("hello", instance.Text);
        }

        [Fact]
        public void CreateInstance_WithArgsAndActivationAttributes_ReturnsInstanceOfT()
        {
            // Arrange
            Type type = typeof(TestClass);
            object[] args = new object[] { "hello" };
            object[] activationAttributes = new object[0]; // .NET Core/Standard 忽略此参数

            // Act & Assert
            Assert.Throws<MissingMethodException>(() =>
            {
                var instance = type.CreateInstance<TestClass>(args, activationAttributes);
            });
        }

        [Fact]
        public void CreateInstance_WithArgsAndActivationAttributes_ReturnsInstance()
        {
            // Arrange
            Type type = typeof(TestClass);
            object[] args = new object[] { "hello" };
            object[] activationAttributes = new object[0]; // .NET Core/Standard ignores this

            // Act
            // 需要使用 BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public 以便找到 private 构造函数
            var result = type.InvokeMember(
                null,
                BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
                null,
                null,
                args,
                CultureInfo.InvariantCulture
            );

            // Assert
            Assert.NotNull(result);
            Assert.IsType<TestClass>(result);
            Assert.Equal("hello", ((TestClass)result).Text);
        }

        [Fact]
        public void CreateInstance_WithBindingFlagsBinderArgsCultureAndActivationAttributes_ReturnsObject()
        {
            // Arrange
            Type type = typeof(TestClass);
            BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Binder binder = Type.DefaultBinder;
            object[] args = new object[] { 30, "Tom" }; // 参数顺序应与构造函数一致
            CultureInfo culture = CultureInfo.InvariantCulture;
            object[] activationAttributes = new object[0]; // .NET Core/Standard 忽略此参数

            // Act
            var result = type.CreateInstance(bindingAttr, binder, args, culture, activationAttributes);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<TestClass>(result);
            var testClass = (TestClass)result;
            Assert.Equal("Tom", testClass.Text);
            Assert.Equal(30, testClass.Value);
        }

        [Fact]
        public void CreateInstance_Generic_NoArgs()
        {
            var type = typeof(TestClass);
            var instance = type.CreateInstance<TestClass>();
            Assert.NotNull(instance);
            Assert.Equal(42, instance.Value);
            Assert.Equal("default", instance.Text);
        }

        [Fact]
        public void CreateInstance_Generic_WithArgs()
        {
            var type = typeof(TestClass);
            var args = new object[] { 99, "hello" };
            var instance = type.CreateInstance<TestClass>(args);
            Assert.NotNull(instance);
            Assert.Equal(99, instance.Value);
            Assert.Equal("hello", instance.Text);
        }

        [Fact]
        public void CreateInstance_Generic_WithBindingFlags()
        {
            var type = typeof(TestClass);
            var args = new object[] { "private" };
            var instance = type.CreateInstance<TestClass>(
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
                null, args, CultureInfo.InvariantCulture);
            Assert.NotNull(instance);
            Assert.Equal(-1, instance.Value);
            Assert.Equal("private", instance.Text);
        }

        [Fact]
        public void CreateInstance_Generic_NonPublic()
        {
            var type = typeof(TestClass);
            var instance = type.CreateInstance<TestClass>(true);
            Assert.NotNull(instance);
            Assert.Equal(42, instance.Value);
        }

        [Fact]
        public void CreateInstance_NonGeneric_NoArgs()
        {
            var type = typeof(TestClass);
            var obj = type.CreateInstance();
            Assert.IsType<TestClass>(obj);
        }

        [Fact]
        public void CreateInstance_NonGeneric_WithArgs()
        {
            var type = typeof(TestClass);
            var args = new object[] { 123, "abc" };
            var obj = type.CreateInstance(args);
            var instance = Assert.IsType<TestClass>(obj);
            Assert.Equal(123, instance.Value);
            Assert.Equal("abc", instance.Text);
        }

        [Fact]
        public void CreateInstance_NonGeneric_WithBindingFlags()
        {
            var type = typeof(TestClass);
            var args = new object[] { "private" };
            var obj = type.CreateInstance(
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
                null, args, CultureInfo.InvariantCulture);
            var instance = Assert.IsType<TestClass>(obj);
            Assert.Equal(-1, instance.Value);
            Assert.Equal("private", instance.Text);
        }

        [Fact]
        public void CreateInstance_NonGeneric_NonPublic()
        {
            var type = typeof(TestClass);
            var obj = type.CreateInstance(true);
            Assert.IsType<TestClass>(obj);
        }

        [Fact]
        public void CreateInstance_WithNullArgsAndActivationAttributes_ReturnsDefaultInstance3()
        {
            var type = typeof(TestClass);
            object[] args = null;
            object[] activationAttributes = null;

            var instance = type.CreateInstance(args, activationAttributes);

            Assert.NotNull(instance);
            Assert.IsType<TestClass>(instance);
            Assert.Equal("default", ((TestClass)instance).Text);
        }
    }
}
