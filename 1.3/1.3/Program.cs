using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
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
                List<int> a = new List<int>();
                List<int> b = new List<int>();
                StreamReader sr = new StreamReader(p.FullName);
                string str = sr.ReadLine();
                string[] arr = str.Split();
                 
            }
        }
    }
}
