using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemInfo dir=new DirectoryInfo(@"F:\111");
            StreamHelper.FileSearch(dir);
            Console.ReadKey();
        }
    }
}
