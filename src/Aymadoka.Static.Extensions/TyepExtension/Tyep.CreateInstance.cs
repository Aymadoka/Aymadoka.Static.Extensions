using System;
using System.Globalization;
using System.Reflection;

namespace Aymadoka.Static.TyepExtension;

public static partial class TyepExtensions
{
    public static T? CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
    {
        var result = (T?)Activator.CreateInstance(@this, bindingAttr, binder, args, culture);
        return result;
    }

    public static T? CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
    {
        var result = (T?)Activator.CreateInstance(@this, bindingAttr, binder, args, culture, activationAttributes);
        return result;
    }

    public static T? CreateInstance<T>(this Type @this, object[] args)
    {
        var result = (T?)Activator.CreateInstance(@this, args);
        return result;
    }

    public static T? CreateInstance<T>(this Type @this, object[] args, object[] activationAttributes)
    {
        var result = (T?)Activator.CreateInstance(@this, args, activationAttributes);
        return result;
    }

    public static T? CreateInstance<T>(this Type @this)
    {
        var result = (T?)Activator.CreateInstance(@this);
        return result;
    }

    public static T? CreateInstance<T>(this Type @this, Boolean nonPublic)
    {
        var result = (T?)Activator.CreateInstance(@this, nonPublic);
        return result;
    }

    public static object? CreateInstance(this Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
    {
        var result = Activator.CreateInstance(type, bindingAttr, binder, args, culture);
        return result;
    }

    public static object? CreateInstance(this Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
    {
        var result = Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
        return result;
    }

    public static object? CreateInstance(this Type type, object[] args)
    {
        var result = Activator.CreateInstance(type, args);
        return result;
    }

    public static object? CreateInstance(this Type type, object[] args, object[] activationAttributes)
    {
        var result = Activator.CreateInstance(type, args, activationAttributes);
        return result;
    }

    public static object? CreateInstance(this Type type)
    {
        var result = Activator.CreateInstance(type);
        return result;
    }

    public static object? CreateInstance(this Type type, bool nonPublic)
    {
        var result = Activator.CreateInstance(type, nonPublic);
        return result;
    }
}
