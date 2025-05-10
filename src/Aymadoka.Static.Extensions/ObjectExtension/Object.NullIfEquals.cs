namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        public static T? NullIfEquals<T>(this T @this, T value) where T : class
        {
            if (@this.Equals(value))
            {
                return null;
            }

            return @this;
        }
    }
}
