namespace Aymadoka.Static.BooleanExtension
{
    public static partial class BooleanExtensions
    {
        public static T To<T>(this bool @this, T trueValue, T falseValue)
        {
            return @this ? trueValue : falseValue;
        }
    }
}
