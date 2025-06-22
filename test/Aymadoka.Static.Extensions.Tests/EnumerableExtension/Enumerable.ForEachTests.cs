namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_ForEachTests
    {
        [Fact]
        public void ForEach_WithActionAndIndex_ExecutesActionForEachElement()
        {
            // Arrange
            var source = new List<string> { "a", "b", "c" };
            var result = new List<(string, int)>();

            // Act
            source.ForEach((item, index) => result.Add((item, index)));

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(("a", 0), result[0]);
            Assert.Equal(("b", 1), result[1]);
            Assert.Equal(("c", 2), result[2]);
        }

        [Fact]
        public void ForEach_WithAction_ExecutesActionForEachElement()
        {
            // Arrange
            var source = new List<int> { 1, 2, 3 };
            var result = new List<int>();

            // Act
            source.ForEach(item => result.Add(item * 2));

            // Assert
            Assert.Equal(new List<int> { 2, 4, 6 }, result);
        }

        [Fact]
        public void ForEach_WithNullActionAndIndex_ThrowsArgumentNullException()
        {
            // Arrange
            var source = new List<int> { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => source.ForEach((Action<int, int>)null));
        }

        [Fact]
        public void ForEach_WithNullAction_ThrowsArgumentNullException()
        {
            // Arrange
            var source = new List<int> { 1, 2, 3 };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => source.ForEach((Action<int>)null));
        }

        [Fact]
        public void ForEach_WithEmptySource_DoesNotInvokeAction()
        {
            // Arrange
            var source = new List<int>();
            var invoked = false;

            // Act
            source.ForEach((item, index) => invoked = true);

            // Assert
            Assert.False(invoked);
        }

        [Fact]
        public void ForEach_Action_PerformsOnAllElements_Array()
        {
            int[] source = { 1, 2, 3, 4 };
            var result = new List<int>();
            source.ForEach(x => result.Add(x * 2));
            Assert.Equal(new[] { 2, 4, 6, 8 }, result);
        }

        [Fact]
        public void ForEach_Action_PerformsOnAllElements_HashSet()
        {
            IEnumerable<int> source = new HashSet<int> { 10, 20, 30 };
            var result = new List<int>();
            source.ForEach(x => result.Add(x + 1));
            Assert.Contains(11, result);
            Assert.Contains(21, result);
            Assert.Contains(31, result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void ForEach_ActionWithIndex_EnumeratesCorrectly()
        {
            Queue<string> source = new Queue<string>(new[] { "a", "b", "c" });
            var result = new List<string>();
            source.ForEach((item, idx) => result.Add($"{idx}:{item}"));
            Assert.Equal(new[] { "0:a", "1:b", "2:c" }, result);
        }

        [Fact]
        public void ForEach_Action_ThrowsOnNullAction()
        {
            IEnumerable<int> source = Enumerable.Range(1, 3);
            Assert.Throws<ArgumentNullException>(() => source.ForEach((Action<int>)null));
        }

        [Fact]
        public void ForEach_ActionWithIndex_ThrowsOnNullAction()
        {
            IEnumerable<int> source = Enumerable.Range(1, 3);
            Assert.Throws<ArgumentNullException>(() => source.ForEach((Action<int, int>)null));
        }

        [Fact]
        public void ForEach_EmptyEnumerable_DoesNotInvokeAction()
        {
            IEnumerable<double> source = new Stack<double>();
            bool called = false;
            source.ForEach(x => called = true);
            Assert.False(called);
        }
    }
}
