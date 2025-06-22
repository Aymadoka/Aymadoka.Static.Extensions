using System;
using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 清空指定目录下的所有文件和子目录。
        /// </summary>
        /// <param name="obj">要清空的目录。</param>
        public static void Clear(this DirectoryInfo obj)
        {
            // 删除所有文件
            Array.ForEach(obj.GetFiles(), x => x.Delete());
            // 删除所有子目录及其内容
            Array.ForEach(obj.GetDirectories(), x => x.Delete(true));
        }
    }
}
