namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static T As<T>(this object @this)
    {
        return (T)@this;
    }
}
