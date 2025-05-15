namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ForEachTests
    {
        [Fact]
        public void ForEach_ActionWithIndex_ExecutesForEachElementWithCorrectIndex()
        {
            // Arrange
            string[] array = { "a", "b", "c" };
            var result = new System.Collections.Generic.List<string>();

            // Act
            array.ForEach((item, index) =>
            {
                result.Add($"{index}:{item}");
            });

            // Assert
            Assert.Equal(new[] { "0:a", "1:b", "2:c" }, result);
        }

        [Fact]
        public void ForEach_ActionWithoutIndex_ExecutesForEachElement()
        {
            // Arrange
            int[] array = { 1, 2, 3 };
            int sum = 0;

            // Act
            array.ForEach(x => sum += x);

            // Assert
            Assert.Equal(6, sum);
        }

        [Fact]
        public void ForEach_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.ForEach((x, i) => { }));
            Assert.Throws<ArgumentNullException>(() => array.ForEach(x => { }));
        }

        [Fact]
        public void ForEach_NullAction_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.ForEach((Action<int, int>)null));
            Assert.Throws<ArgumentNullException>(() => array.ForEach((Action<int>)null));
        }
    }
}
