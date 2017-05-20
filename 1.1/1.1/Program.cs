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
        public static List<int> a;
        public static List<int> b;
        public static bool came = false;
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"papka");
            List<FileInfo> fil = new List<FileInfo>();
            fil.AddRange(dir.GetFiles());
            foreach(FileInfo p in fil)
            {
                StreamReader sr = new StreamReader(p.FullName);
                string str = sr.ReadLine();
                string[] arr = str.Split();
                for (int i = 2; i <= int.Parse(arr[0]); i++)
                {
                    if (int.Parse(arr[0]) % i == 0)
                        a.Add(i);
                }
                for(int j = 2; j <= int.Parse(arr[1]); j++)
                {
                    if (int.Parse(arr[1]) % j == 0)
                        b.Add(j);
                }
                foreach(int z in a)
                {
                    for(int u = 0; u <= b.Count; u++)
                    {
                        if (z == b[u])
                        {
                            came = true;
                        }
                        }
                }
                if(came)
                    Console.WriteLine(p.Name + ':' + "yes");
                    else
                    Console.WriteLine(p.Name+':'+"no");
            }


            //StreamReader sr = new StreamReader(@"file1.txt");
            Console.ReadKey();
        }
    }
}
