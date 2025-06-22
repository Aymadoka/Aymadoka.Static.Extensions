using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public class StringBuilder_AppendIfTests
    {
        [Fact]
        public void AppendIf_Appends_Values_That_Match_Predicate()
        {
            var sb = new StringBuilder();
            sb.AppendIf<int>(x => x % 2 == 0, 1, 2, 3, 4, 5);
            Assert.Equal("24", sb.ToString());
        }

        [Fact]
        public void AppendIf_Does_Not_Append_When_No_Values_Match()
        {
            var sb = new StringBuilder();
            sb.AppendIf<string>(s => s.StartsWith("z"), "apple", "banana", "cat");
            Assert.Equal(string.Empty, sb.ToString());
        }

        [Fact]
        public void AppendIf_Appends_All_When_All_Match()
        {
            var sb = new StringBuilder();
            sb.AppendIf<char>(c => char.IsLetter(c), 'a', 'b', 'c');
            Assert.Equal("abc", sb.ToString());
        }

        [Fact]
        public void AppendIf_With_Empty_Values_Does_Nothing()
        {
            var sb = new StringBuilder("init");
            sb.AppendIf<int>(x => x > 0);
            Assert.Equal("init", sb.ToString());
        }

        [Fact]
        public void AppendIf_Null_Predicate_Throws()
        {
            var sb = new StringBuilder();
            Assert.Throws<NullReferenceException>(() => sb.AppendIf<int>(null, 1, 2));
        }

        [Fact]
        public void AppendIf_Null_StringBuilder_Throws()
        {
            StringBuilder sb = null;
            Assert.Throws<ArgumentNullException>(() => sb.AppendIf<int>(x => x > 0, 1, 2));
        }
    }
}
