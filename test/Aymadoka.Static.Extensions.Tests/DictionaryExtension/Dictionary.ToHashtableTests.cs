using System.Collections;

namespace Aymadoka.Static.DictionaryExtension
{
    public class Dictionary_ToHashtableTests
    {
        [Fact]
        public void ToHashtable_FromDictionary_ReturnsEquivalentHashtable()
        {
            // Arrange
            IDictionary dict = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 }
            };

            // Act
            var hashtable = dict.ToHashtable();

            // Assert
            Assert.IsType<Hashtable>(hashtable);
            Assert.Equal(dict.Count, hashtable.Count);
            foreach (DictionaryEntry entry in hashtable)
            {
                Assert.True(dict.Contains(entry.Key));
                Assert.Equal(dict[entry.Key], entry.Value);
            }
        }

        [Fact]
        public void ToHashtable_FromEmptyDictionary_ReturnsEmptyHashtable()
        {
            // Arrange
            IDictionary dict = new Dictionary<int, string>();

            // Act
            var hashtable = dict.ToHashtable();

            // Assert
            Assert.IsType<Hashtable>(hashtable);
            Assert.Empty(hashtable);
        }

        [Fact]
        public void ToHashtable_Null_ThrowsArgumentNullException()
        {
            // Arrange
            IDictionary dict = null;

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => dict.ToHashtable());
        }
    }
}
