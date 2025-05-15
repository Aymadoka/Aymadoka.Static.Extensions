namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ToDataTableTests
    {
        // 测试类
        public class TestClass
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public bool IsActive = true;

            public string Description = null;
        }

        // 测试结构体
        public struct TestStruct
        {
            public float Value;
            public DateTime CreatedAt { get; set; }
        }

        [Fact]
        public void ToDataTable_ShouldCreateCorrectColumns_ForClassWithPropertiesAndFields()
        {
            // Arrange
            var testData = new TestClass[] {
                new TestClass { Id = 1, Name = "A", IsActive = true },
                new TestClass { Id = 2, Name = "B", IsActive = false }
            };

            // Act
            var result = testData.ToDataTable();

            // Assert
            Assert.Equal(4, result.Columns.Count);
            Assert.Equal("Id", result.Columns[0].ColumnName);
            Assert.Equal(typeof(int), result.Columns[0].DataType);
            Assert.Equal("Name", result.Columns[1].ColumnName);
            Assert.Equal("IsActive", result.Columns[2].ColumnName);
            Assert.Equal(2, result.Rows.Count);
        }

        [Fact]
        public void ToDataTable_ShouldHandleNullElements()
        {
            // Arrange
            var testData = new TestClass[] {
                new TestClass { Id = 1 },
                null,
                new TestClass { Id = 3 },
            };

            // Act
            var result = testData.ToDataTable();

            // Assert
            Assert.Equal(3, result.Rows.Count);
            Assert.Equal(DBNull.Value, result.Rows[1]["Id"]);
        }

        [Fact]
        public void ToDataTable_ShouldCreateEmptyTable_ForTypeWithoutPublicMembers()
        {
            // Arrange
            var testData = new object[] { new object(), new object() };

            // Act
            var result = testData.ToDataTable();

            // Assert
            Assert.Empty(result.Columns);
            Assert.Equal(2, result.Rows.Count);
        }

        [Fact]
        public void ToDataTable_ShouldHandleValueTypes()
        {
            // Arrange
            var testData = new TestStruct[] {
                new TestStruct { Value = 1.5f, CreatedAt = DateTime.Today }
            };

            // Act
            var result = testData.ToDataTable();

            // Assert
            Assert.Equal(2, result.Columns.Count);
            Assert.Equal(typeof(float), result.Columns["Value"].DataType);
            Assert.Equal(DateTime.Today, result.Rows[0]["CreatedAt"]);
        }
    }
}
