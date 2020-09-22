using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace StreamStudy
{   /// <summary>
    /// 处理IO，流的帮助类
    /// </summary>
    class StreamHelper
    {
        public static void FileSearch(FileSystemInfo fileSystemInfo)
        {
            if (!fileSystemInfo.Exists)
            {
                return;
            }
            //不是目录
            DirectoryInfo drInfo = fileSystemInfo as DirectoryInfo;
            if (drInfo == null)
            {
                return;
            }
            FileSystemInfo[] fileInfos = drInfo.GetFileSystemInfos();
            foreach (var item in fileInfos)
            {
                FileInfo file = item as FileInfo;
                //是文件
                if (file != null)
                {
                    Console.WriteLine("文件:" + item.Name + "路径:" + item.FullName);
                }
                //是目录
                else
                {
                    //递归
                    FileSearch(item);
                }
            }
        }
    }
}
