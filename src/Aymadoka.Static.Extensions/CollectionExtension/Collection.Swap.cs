using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        public static void Swap<T>(this ICollection<T> @this, T oldValue, T newValue)
        {
            if (@this is IList<T> list)
            {
                var oldIndex = list.IndexOf(oldValue);
                while (oldIndex > 0)
                {
                    list.RemoveAt(oldIndex);
                    list.Insert(oldIndex, newValue);
                    oldIndex = list.IndexOf(oldValue);
                }
            }
            else
            {
                var updatedCollection = @this.Select(item => EqualityComparer<T>.Default.Equals(item, oldValue) ? newValue : item).ToList();

                @this.Clear();
                foreach (var item in updatedCollection)
                {
                    @this.Add(item);
                }
            }
        }
    }
}
