namespace Aymadoka.Static.RandomExtension
{
    public class Random_OneOfTests
    {
        [Fact]
        public void OneOf_ReturnsElementFromValues()
        {
            var random = new Random(42);
            var values = new[] { "A", "B", "C", "D" };
            var result = random.OneOf(values);
            Assert.Contains(result, values);
        }

        [Fact]
        public void OneOf_ReturnsDifferentResults()
        {
            var random = new Random();
            var values = new[] { 1, 2, 3, 4, 5 };
            bool foundDifferent = false;
            int first = random.OneOf(values);
            for (int i = 0; i < 20; i++)
            {
                if (random.OneOf(values) != first)
                {
                    foundDifferent = true;
                    break;
                }
            }
            Assert.True(foundDifferent);
        }

        [Fact]
        public void OneOf_ThrowsArgumentException_WhenValuesEmpty()
        {
            var random = new Random();
            Assert.Throws<IndexOutOfRangeException>(() => random.OneOf<int>());
        }
    }
}
