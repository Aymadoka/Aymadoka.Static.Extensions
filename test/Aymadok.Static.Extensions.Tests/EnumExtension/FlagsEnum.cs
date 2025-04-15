namespace Aymadok.Static.EnumExtension
{
    [Flags]
    public enum FlagsEnum
    {
        None = 0,
        Option1 = 1,
        Option2 = 2,
        Option3 = 4,
        All = Option1 | Option2 | Option3
    }
}
