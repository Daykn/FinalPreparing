using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"papka");
            List<FileInfo> fil = new List<FileInfo>();
            fil.AddRange(dir.GetFiles());
            foreach(FileInfo p in fil)
            {
                Console.WriteLine(p.Name);
            }


            //StreamReader sr = new StreamReader(@"file1.txt");
            Console.ReadKey();
        }
    }
}
