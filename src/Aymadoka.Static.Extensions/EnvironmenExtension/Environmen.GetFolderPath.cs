using System;

namespace Aymadoka.Static.EnvironmenExtension
{
    public static partial class EnvironmenExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="Environment.SpecialFolder"/> 的路径。
        /// </summary>
        /// <param name="this">要获取路径的特殊文件夹枚举值。</param>
        /// <returns>指定特殊文件夹的路径。</returns>
        public static string GetFolderPath(this Environment.SpecialFolder @this)
        {
            return Environment.GetFolderPath(@this);
        }

        /// <summary>
        /// 获取指定 <see cref="Environment.SpecialFolder"/> 的路径，并指定选项。
        /// </summary>
        /// <param name="this">要获取路径的特殊文件夹枚举值。</param>
        /// <param name="option">用于检索特殊文件夹的选项。</param>
        /// <returns>指定特殊文件夹的路径。</returns>
        public static string GetFolderPath(this Environment.SpecialFolder @this, Environment.SpecialFolderOption option)
        {
            return Environment.GetFolderPath(@this, option);
        }
    }
}
