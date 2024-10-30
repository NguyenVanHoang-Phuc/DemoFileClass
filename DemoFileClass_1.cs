using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileClass
{
    public class DemoFileClass_1
    {
        static void Main(string[] args)
        {
            string path = "MyFile_1.txt";
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);
                sw.WriteLine("FPTU DA NANG");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
            using StreamReader sr = File.OpenText(path);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
