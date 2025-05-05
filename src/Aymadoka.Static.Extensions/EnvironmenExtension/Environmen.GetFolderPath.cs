using System;

namespace Aymadoka.Static.EnvironmenExtension
{
    public static partial class EnvironmenExtensions
    {
        public static string GetFolderPath(this Environment.SpecialFolder @this)
        {
            return Environment.GetFolderPath(@this);
        }

        public static string GetFolderPath(this Environment.SpecialFolder @this, Environment.SpecialFolderOption option)
        {
            return Environment.GetFolderPath(@this, option);
        }
    }
}
