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
        public static int t = 0;
        public static bool came = false;
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"papka");
            List<FileInfo> fil = new List<FileInfo>();
            fil.AddRange(dir.GetFiles());
            foreach(FileInfo p in fil)
            {
                List<int> a=new List<int>();
                List<int> b=new List<int>();
                StreamReader sr = new StreamReader(p.FullName);
                string str = sr.ReadToEnd();
                string[] arr = str.Split();
                for (int i = 2; i < Math.Min(int.Parse(arr[0]), int.Parse(arr[1])); i++)
                {
                    if (int.Parse(arr[0]) % i == 0)
                        a.Add(i);
                }
                for(int j = 2; j < Math.Min(int.Parse(arr[0]), int.Parse(arr[1])); j++)
                {
                    if (int.Parse(arr[1]) % j == 0)
                        b.Add(j);
                }
                for(int k=0;k<a.Count;k++)
                {
                    for (int u = 0; u < b.Count; u++)
                    {
                        if (a[k] == b[u])
                            t++;
                    }
                }
                if(t>1)
                    Console.WriteLine(p.Name + ':' + "yes");
                    else
                    Console.WriteLine(p.Name+':'+"no");
            }


            //StreamReader sr = new StreamReader(@"file1.txt");
            Console.ReadKey();
        }
    }
}
